using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication1.Abstract;
using WebApplication1.Data;
using WebApplication1.DTO;
using WebApplication1.Entities;

namespace WebApplication1.Implementation
{
    public class ConfigImplementation : IConfigService
    {
        private readonly DataContext _dataContext;

        public ConfigImplementation(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<AttendenceConfigs> AddConfigAsync(AddConfigDto addConfigDto)
        {
            //throw new System.NotImplementedException();
            //var previousConfig = _dataContext.AttendenceConfigs.Find(id);

            TimeSpan maxPunchIn = TimeSpan.Parse(addConfigDto.MaxPunchIn);
            TimeSpan minPunchOut = TimeSpan.Parse(addConfigDto.MinPunchOut);

            var config = new AttendenceConfigs()
            {
                MaxPunchIn = maxPunchIn,
                MinPunchOut = minPunchOut,
                IsActive = true
            };

            //_dataContext.AttendenceConfigs.Remove(previousConfig);
            await _dataContext.AddAsync(config);
            await _dataContext.SaveChangesAsync();

            return config;
         }

        public async Task<List<AttendenceConfigs>> GetConfigAsync()
        {
            return await _dataContext.AttendenceConfiguration.ToListAsync();
        }
    }
}
