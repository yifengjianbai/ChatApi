using Autofac;
using DbService.Models;
using DbService.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DbService.Service.Experience
{
    /// <summary>
    /// 每日评论
    /// </summary>
    public class RemarkAction : BaseAction
    {
        private readonly IRpRepository<RpMomentComment> _commentRepo;
        public RemarkAction(IContainer container) : base(container)
        {
            _commentRepo = container.Resolve<IRpRepository<RpMomentComment>>();
        }

        /// <summary>
        /// 可否允许获取经验
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="expAcquire"></param>
        /// <returns></returns>
        protected override async Task<bool> AllowIncreaseUserExpAsync(RpUserInfo userInfo, RpExpAcquireSetting expAcquire)
        {
            //当天最近一条记录
            var lastComment = await _commentRepo.Where(x => x.UserId == userInfo.UserId && x.CreateTime.Date == DateTime.Now.Date).OrderByDescending(x => x.CreateTime).FirstOrDefaultAsync();
            if (lastComment == null) return false;

            //去除最近一条记录的所有评论
            var moments = await _commentRepo.Where(x => x.UserId == userInfo.UserId && x.CreateTime.Date == DateTime.Now.Date && x.CommentId != lastComment.CommentId).Select(x => x.MomentId).ToListAsync();
            var momentCount = moments.Count();
            var limitCount = userInfo.IsVip ? expAcquire.VipLimitNum : expAcquire.LimitNum;

            //首次评论，可获取经验
            if (momentCount == 0) return true;
            if (momentCount > limitCount)
            {
                return false;
            }
            else
            {
                //相同的动态 多次评论不获取经验 
                var existed = moments.Exists(x => x.Equals(lastComment.CommentId));
                return !existed;
            }

        }
    }
}
