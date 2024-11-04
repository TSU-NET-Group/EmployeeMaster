using Microsoft.AspNetCore.Mvc;


namespace Server_side.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KeyCardAuth : ControllerBase
    {

        public static List<int> KeyCards = new List<int>{1,2,3,4};
        public static List<int> Devices = new List<int> {1,2,3,4};



        [HttpGet(Name = "KeyCardAuth")]
        public IActionResult Get(int deviceId , int cardId,uint time)
        {

            //check if device exists 

            if (!Devices.Contains(deviceId)) return NotFound("no device found");


            //check if card exists 
            //right now works only on files

            if (!KeyCards.Contains(cardId)) return NotFound("no card found");


            //sanity check on time
            long secondsSinceEpoch = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            if (time > secondsSinceEpoch || time < 0) return BadRequest("wrong time stated");
            
            
            return Ok($"Found {deviceId} for {cardId} at {time}");
        }
    }
}
