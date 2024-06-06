using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.Text;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace ATMGO20MPOS.Common
{
    public class JwtManager
    {
        //public static ILog netLog = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private const string Secret = "euxv7oOJtrxPPrixWJLCPsjnuRkgEtbccN2h1F+U165Lab5Lf9CiS1HLN+ATH4N2yf49hrEYwvN/8uOL8x2cdA==";

        public string GenerateToken(string username, string userrole, int expireMinutes = 120)
        {
            //var hmac = new HMACSHA256();
            //var Secret = Convert.ToBase64String(hmac.Key);
            //strJWTKey = Secret;

            var symmetricKey = Convert.FromBase64String(Secret);
            var tokenHandler = new JwtSecurityTokenHandler();

            var now = DateTime.UtcNow;
            var tokenDescriptor = new Microsoft.IdentityModel.Tokens.SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                        {
                            new Claim(ClaimTypes.Name, username),
                            new Claim(ClaimTypes.Role, userrole)
                        }),

                Expires = now.AddMinutes(Convert.ToInt32(expireMinutes)),

                SigningCredentials = new Microsoft.IdentityModel.Tokens.SigningCredentials(new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(symmetricKey),
                Microsoft.IdentityModel.Tokens.SecurityAlgorithms.HmacSha256Signature)
            };

            var stoken = tokenHandler.CreateToken(tokenDescriptor);
            var token = tokenHandler.WriteToken(stoken);

            return token;
        }

        public static ClaimsPrincipal GetPrincipal(string token)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();

                if (!(tokenHandler.ReadToken(token) is JwtSecurityToken jwtToken))
                    return null;

                var symmetricKey = Convert.FromBase64String(Secret);

                var validationParameters = new TokenValidationParameters()
                {
                    RequireExpirationTime = true,
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    IssuerSigningKey = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(symmetricKey)
                };

                var principal = tokenHandler.ValidateToken(token, validationParameters, out SecurityToken securityToken);

                return principal;
            }

            catch (Exception Ex)
            {
                string strErrorReason = Ex.Message;
                return null;
            }
        }

        //"GETTING REQUEST DATA USING PRIVATE KEY"
        public static string DecryptCertEncryptedMsg(string Data, string TerminalID = "")
        {
            
            string Response = string.Empty;

            try
            {
                Data = Data.Replace(" ", "+");
                System.Security.Cryptography.X509Certificates.X509Store store = new System.Security.Cryptography.X509Certificates.X509Store("MY", StoreLocation.LocalMachine);
                store.Open(OpenFlags.ReadOnly | OpenFlags.OpenExistingOnly);
                X509Certificate2Collection collection = (X509Certificate2Collection)store.Certificates;

                X509Certificate2Collection fcollection = (X509Certificate2Collection)collection;

               


                if (fcollection.Count == 1)
                {
                    X509Certificate2 cert = fcollection[0];
                    RSACryptoServiceProvider ser = (RSACryptoServiceProvider)cert.PrivateKey;
                    var test = Convert.FromBase64String(Data);
                    var dec_data = ser.Decrypt(Convert.FromBase64String(Data), false);
                    Response = Encoding.UTF8.GetString(dec_data);
                }
            }
            catch (Exception Ex)
            {
                Response = "";
            }
            

            return Response;
        }

        #region "Getting Request data using Public Key"
        public static bool FunValidateItegrationMessage(string token, out string data)
        {
            bool retStatus = false;
            try
            {
                data = null;

                var simplePrinciple = GetRSAPrincipal(token);

                if (simplePrinciple != null)
                {
                    var identity = simplePrinciple.Identity as ClaimsIdentity;

                    if (identity == null)
                        retStatus = false;

                    if (!identity.IsAuthenticated)
                        retStatus = false;

                    var usernameClaim = identity.FindFirst(ClaimTypes.Name);
                    data = usernameClaim?.Value;

                    if (string.IsNullOrEmpty(data))
                    {
                        retStatus = false;
                    }
                    else
                    {
                        retStatus = true;
                    }
                }
                else
                {
                    retStatus = false;
                }
            }
            catch (Exception)
            {
                data = null;
                retStatus = false;
            }

            return retStatus;
        }

        public static ClaimsPrincipal GetRSAPrincipal(string token)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();

                if (!(tokenHandler.ReadToken(token) is JwtSecurityToken jwtToken))
                    return null;
                string key = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAqbBilcuEEPmC9GvDnYuMqNUMIEuZXQpEqhvYLLeDO91g/eBuvgO2nWJCzTfsOMOsuKqJ8XRBJWLxwx+NlW1Mtp02dfhu+xghPnQ6OFHD1r00l1Dgo8VKrKnldg1i/IOXdoQUsv7mihRQWPZaMypw+AUiR64R0Ylr59aYa8bcsQg/xgIgpqZBKyPwydBg57H37uWM1udZcP4xEnXcsUdYc/TnFJ+/CHpQO05GX41cEs5OpJjbeL+f188fwSt9uDGErAaUgxYCnP4Tt7FGFlWaLkayCeVGCdTPjBWwhONDlD+WmUGTMBaCCM7NngoHYoXoBJRujzImgeWyjoR3NsX9eQIDAQAB";

                var keyBytes = Convert.FromBase64String(key); // your key here

                AsymmetricKeyParameter asymmetricKeyParameter = PublicKeyFactory.CreateKey(keyBytes);
                RsaKeyParameters rsaKeyParameters = (RsaKeyParameters)asymmetricKeyParameter;
                RSAParameters rsaParameters = new RSAParameters
                {
                    Modulus = rsaKeyParameters.Modulus.ToByteArrayUnsigned(),
                    Exponent = rsaKeyParameters.Exponent.ToByteArrayUnsigned()
                };

                var validationParameters = new TokenValidationParameters()
                {
                    RequireExpirationTime = true,
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    IssuerSigningKey = new Microsoft.IdentityModel.Tokens.RsaSecurityKey(rsaParameters)
                };

                var principal = tokenHandler.ValidateToken(token, validationParameters, out SecurityToken securityToken);

                return principal;
            }

            catch (Exception Ex)
            {
                string strErrorReason = Ex.Message;
                return null;
            }
        }
        #endregion

        public static string EncryptRsaMessage(string Data)
        {
            string Response = string.Empty;

            try
            {
                Data = Data.Replace(" ", "+");
                System.Security.Cryptography.X509Certificates.X509Store store = new System.Security.Cryptography.X509Certificates.X509Store("MY", StoreLocation.LocalMachine);

                store.Open(OpenFlags.ReadOnly | OpenFlags.OpenExistingOnly);
                X509Certificate2Collection collection = (X509Certificate2Collection)store.Certificates;

                X509Certificate2Collection fcollection = (X509Certificate2Collection)collection;

                if (fcollection.Count == 1)
                {
                    X509Certificate2 cert = fcollection[0];
                    RSACryptoServiceProvider ser = (RSACryptoServiceProvider)cert.PrivateKey;

                    RSACryptoServiceProvider rsaEncryptor = (RSACryptoServiceProvider)cert.PrivateKey;

                    byte[] bytesData = Encoding.UTF8.GetBytes(Data);
                    byte[] bytesEncrypted = ser.Encrypt(bytesData, true);
                    Response = Convert.ToBase64String(bytesEncrypted);
                }
            }
            catch (Exception)
            {
                Response = "";
            }

            return Response;
        }
    }

}
