using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimalGroups.DAO;
using AnimalGroups.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AnimalGroups.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalGroupNameController : ControllerBase
    {
        [HttpGet]
        public ActionResult Instructions()
        {
            return Ok("useage: api/animalgroupname/<name of animal>");
        }
        [HttpGet("{AnimalName}")]
        public ActionResult GrabTheGroupName(string AnimalName)
        {
            AnimalInfoDictionaryDAO dao = new AnimalInfoDictionaryDAO();
            Animal animalInfo = dao.GetAnimalInformation(AnimalName);
            if(animalInfo.GroupName.Contains("unknown"))
            {
                return NotFound();
            }
            return Ok(animalInfo);
        }
    }
}