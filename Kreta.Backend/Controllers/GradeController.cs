﻿using Kreta.Backend.Controllers.Assamblers;
using Kreta.Backend.Repos;
using Kreta.Shared.Dtos;
using Kreta.Shared.Models.SchoolCitizens;
using Microsoft.AspNetCore.Mvc;

namespace Kreta.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GradeController : BaseController<Grade, GradeDto>
    {
        public GradeController(GradeAssambler assembler, IGradeRepo repo) : base(assembler, repo)
        {
        }
    }
}
