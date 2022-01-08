using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using VolumeWebService.Data;
using VolumeWebService.DataAccess;
using VolumeWebService.VolumeCalculator;

namespace VolumeWebService.Controllers
{
    [ApiController]
    [Route("/calculate/")]
    public class CalculatorController : ControllerBase
    {
        private Calculator _calculator;
        private IVolumeResultRepository _volumeResultRepository;

        public CalculatorController(Calculator calculator, IVolumeResultRepository repository)
        {
            this._calculator = calculator;
            this._volumeResultRepository = repository;
        }

        [HttpGet("cylinder/height={height}&radius={radius}")]
        public VolumeResult CalculateCylinderVolume(double height, double radius)
        {
            VolumeResult result = _calculator.CalculateVolumeCylinder(height, radius);
            _volumeResultRepository.AddResult(result);
            string resultAsJson = JsonConvert.SerializeObject(result);
            Console.WriteLine(resultAsJson);
            return result;
        }

        [HttpGet("cone/radius={radius}&height={height}")]
        public VolumeResult CalculateConeVolume(double radius, double height)
        {
            VolumeResult result = _calculator.CalculateVolumeCone(radius, height);
            _volumeResultRepository.AddResult(result);
            string resultAsJson = JsonConvert.SerializeObject(result);
            Console.WriteLine(resultAsJson);
            return result;
        }

        [HttpGet]
        [Route("results")]
        public List<VolumeResult> GetAllResult()
        {
            return _volumeResultRepository.GetAllResults();
        }
    }
}