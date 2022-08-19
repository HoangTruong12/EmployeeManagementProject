﻿using ClosedXML.Excel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Test.Modal.Entities;
using Test.Services.Interface;

namespace Test.WebAPI.Controllers
{
    [Authorize]
    public class ExcelController : BaseController
    {
        private readonly IExcelService _excelService;
        public ExcelController(IExcelService excelService)
        {
            _excelService = excelService;
        }

        [HttpGet("download")]
        public string Download()
        {
            var content = _excelService.Download();
            return content;
        }

        [HttpPost("import")]
        public async Task<IActionResult> Import(IFormFile file)
        {
            bool checkIfExcelFile = _excelService.CheckIfExcelFile(file);
            if (checkIfExcelFile)
            {
                await _excelService.Import(file);
            }
            else
            {
                return BadRequest("Invalid file extension");
            }
            return Ok("Uploaded success");
        }
    }
}
