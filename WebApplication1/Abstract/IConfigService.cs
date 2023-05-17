using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication1.DTO;
using WebApplication1.Entities;

namespace WebApplication1.Abstract
{
    public interface IConfigService
    {
        Task<AttendenceConfigs> AddConfigAsync(AddConfigDto addConfigDto);

        Task<List<AttendenceConfigs>> GetConfigAsync();


    }
}
