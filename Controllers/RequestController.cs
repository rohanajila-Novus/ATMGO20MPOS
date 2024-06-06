using ATMGO20MPOS.Models;
using ATMGO20MPOS.RequestModels;
using Microsoft.AspNetCore.Mvc;


namespace ATMGO20MPOS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestController : ControllerBase
    {

        private readonly RCBC_MPOS_UATContext _context;

        public RequestController(RCBC_MPOS_UATContext context)
        {
            _context = context;
        }

        [HttpPost("LoginRequest")]
        public IActionResult LoginRequest([FromBody] LoginRequestModel request)
        {

            string AppVersion = string.Empty, IsForceUpdate = string.Empty, ForceUpdateMsg = string.Empty, RecommendUpdateMsg = string.Empty, APKType = "", RESPONSECODE="", RESPONSEMSG="", BUILDUPDATEFORMOBILE="";
                //string PAXIsForceUpdateForUserBatch = "0";
                string RecommendUpdateUsers = "";
            // Validate the request parameters 
            if (string.IsNullOrEmpty(request.Username) || string.IsNullOrEmpty(request.Password))
            {
                return BadRequest("Invalid request. Username and password are required.");

            }

            //Validate Version of Application 
            //try
            //{
                

            //    AppVersion = _context.MasParams.Where(x => x.ParamName.ToUpper() == "PAXAPPVERSION").Select(x => x.ParamValue).FirstOrDefault();
            //    IsForceUpdate = _context.MasParams.Where(x => x.ParamName.ToUpper() == "PAXISFORCEUPDATE").Select(x => x.ParamValue).FirstOrDefault();                
            //    ForceUpdateMsg = _context.MasParams.Where(x => x.ParamName.ToUpper() == "PAXFORCEUPDATEMSG").Select(x => x.ParamValue).FirstOrDefault();
            //    RecommendUpdateMsg = _context.MasParams.Where(x => x.ParamName.ToUpper() == "PAXRECOMMENDUPDATEMSG").Select(x => x.ParamValue).FirstOrDefault();
            //    APKType = "PAX";
                
            //    if (AppVersion == "") { AppVersion = "0"; }
            //    if (Convert.ToDouble(request.Version) == Convert.ToDouble(AppVersion))
            //    {
            //        RESPONSECODE = "00";

            //    }
            //    else if (Convert.ToDouble(request.Version) < Convert.ToDouble(AppVersion))
            //    {
            //        if (APKType == "PAX")
            //        {
            //            BUILDUPDATEFORMOBILE = _context.MasParams.Where(x => x.ParamName.ToUpper() == "BUILDUPDATEFORMOBILE").Select(x => x.ParamValue).FirstOrDefault();
                        
            //            RecommendUpdateUsers = _context.MasParams.Where(x => x.ParamName.ToUpper() == "RECOMMANDEDUPDATEFORPAX").Select(x => x.ParamValue).FirstOrDefault();

            //        }
                    

            //        //--Forupdate User List 
            //        if (string.IsNullOrEmpty(BUILDUPDATEFORMOBILE))
            //        {
            //            if (IsForceUpdate.Trim() == "0")
            //            {
            //                RESPONSECODE = "21";
            //                RESPONSEMSG = RecommendUpdateMsg;
            //            }
            //            else
            //            {
            //                RESPONSECODE = "22";
            //                RESPONSEMSG = ForceUpdateMsg;
            //            }
            //        }
            //        else
            //        {
            //            List<string> LstUserNames = BUILDUPDATEFORMOBILE.Split(',').ToList();
            //            if (LstUserNames.Contains(request.Username.ToUpper()))
            //            {
            //                /// stop Recommended update and set force update ...
            //                //objData.RESPONSECODE = "21";
            //                //objData.RESPONSEMSG = RecommendUpdateMsg;

            //                RESPONSECODE = "22";
            //                RESPONSEMSG = ForceUpdateMsg;

            //            }
            //            else
            //            {
            //                if (IsForceUpdate.Trim() == "1")
            //                {
            //                    RESPONSECODE = "22";
            //                    RESPONSEMSG = ForceUpdateMsg;
            //                }
            //            }

            //        }
            //        ///Start Check Recommended  USer List
            //        List<string> RecommendedLstUserNames = RecommendUpdateUsers.Split(',').ToList();
            //        if (RecommendedLstUserNames.Contains(request.Username.ToUpper()))
            //        {
            //            RESPONSECODE = "21";
            //            RESPONSEMSG = RecommendUpdateMsg;
            //        }
            //        else
            //        {
            //            if (IsForceUpdate.Trim() == "1")
            //            {
            //                RESPONSECODE = "22";
            //                RESPONSEMSG = ForceUpdateMsg;
            //            }
            //        }
            //        //End 
            //    }
            //    else
            //    {
            //        RESPONSECODE = "23";
            //    }
            //}
            //catch (Exception ex)
            //{
            //    RESPONSECODE = "56";
                

            //}
            

            // Perform authentication logic (e.g., check credentials against a database)
            bool isAuthenticated = AuthenticateUser(request.Username, request.Password);

            if (isAuthenticated)
            {
                var successResponse = new
                {
                    ResponseCode = "00",
                    ResponseMsg = "Success",
                    Data = new
                    {
                        Token = GenerateAuthToken(request.Username),
                        IsSetMPIN = "0",
                        IsChangePassword = "0",
                        TerminalName = "62000002",
                        Email = "a4mbhi@gmail.com",
                        Address = "Mumbai ",
                        LastLoginDate = "10:16, May 08, 2024",
                        TerminalKey = "",
                        MerchantID =  "880000000000002",
                        MerchantName = "EL 82/83, MIDC Area, TTC Industrial Estate, Near Suyog Hotel, Mahape, Navi Mumbai.",
                        MerchantAddress = "DineshPal",
                        MerchantNameAddress ="Wesh Spa and Massage     Northen Pob. PH",
                        DeviceAddress = "0821355622",
                        DeviceSerialNumber = "PAX",
                        IsFirstLogin = "False",
                        Phone = "6393904435",
                        Region = "ARAYAT",
                        Currency = "PHP",
                        AppSessionTimeout = 5,
                        SessionKey = "9718202405082659",
                        UserID = "124",
                        PartnerMerchantID = "F46A6106-5C61-4715-A261-8B0E3AE6BA58"


                    }
            // Other properties as needed
        };
                return Ok(successResponse);
            }
            else
            {
                // Failure response
                var failureResponse = new
                {
                    ResponseCode = "35",
                    ResponseMsg = "Invalid Username or Password",
                    Data = new { }
                };
                return BadRequest(failureResponse);
            }
        }

        // Simulated authentication logic (replace with your actual logic)
        private bool AuthenticateUser(string username, string password)
        {
            // Your authentication logic here (e.g., check against a user database)
            // Return true if authentication succeeds, false otherwise
            return username == "rcbc2" && password == "rcbc2";
        }

        // Simulated token generation (replace with your actual token generation logic)
        private string GenerateAuthToken(string username)
        {
            // Generate a JWT token or any other type of token
            // Example: return a hardcoded token for demonstration purposes
            return "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6InJjYmMyIiwicm9sZSI6IjIiLCJuYmYiOjE3MTUxNzMwMzUsImV4cCI6MTcxNTE3MzYzNSwiaWF0IjoxNzE1MTczMDM1fQ.okSAV5hOFDxwHp8Dgj3hVza8q2O8KjOFT-Ebx4xOpMU";
        }
    }
}

