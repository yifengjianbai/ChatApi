using DbService.IService;
using DbService.Models;
using DbService.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DbService.Service
{
    /// <summary>
    /// 用户追踪服务
    /// </summary>
    public class UserTrackService : IUserTrackService
    {
        public readonly IRpRepository<RpUserTrack> _userTrackRpRepository;
        public UserTrackService(IRpRepository<RpUserTrack> rpRepository)
        {
            _userTrackRpRepository = rpRepository;
        }

        /// <summary>
        /// 保存用户定位
        /// </summary>
        /// <param name="track"></param>
        /// <returns></returns>
        public async Task SaveUserTrackAsync(string userId, double longitude, double latitude)
        {
            //todo:用户定位 gpsLocation 修改为经纬度显示
            var track = new RpUserTrack();
            //track.UserId = userId;
            //track.GpsLocation
            await _userTrackRpRepository.AddAsync(track);
        }
    }
}
