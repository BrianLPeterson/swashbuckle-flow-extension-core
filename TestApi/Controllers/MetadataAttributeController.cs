﻿using Microsoft.AspNetCore.Mvc;
using SwashBuckle.MicrosoftExtensions.Attributes;
using SwashBuckle.MicrosoftExtensions.Filters;
using TestApi.Models;

namespace TestApi.Controllers
{
    [Route("api/[controller]")]
    public class MetadataAttributeController : Controller
    {
        [HttpPost]
        [Metadata("FriendlyAction", "ActionDescription", VisibilityType.Important)]
        public MetdataAttributeClass Post([FromBody][Metadata("FriendlyParameter", "ParameterDescription")] string value)
        {
            return null;
        }
    }
}