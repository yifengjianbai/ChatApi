using AutoMapper;
using DbService.Models;
using Infrastructure.CommonModels;
using Infrastructure.CommonModels.Moment;
using Infrastructure.CommonModels.User;
using Infrastructure.CommonModels.Wish;
using Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<RegistUserInfo, RpUserInfo>()
                .ForMember(r => r.Genders, u => u.MapFrom(r => (byte)r.Genders))
                .ForMember(r => r.Age, u => u.MapFrom(r => (byte)r.Age))
                .ForMember(r => r.UserTags, u => u.MapFrom(r => r.Tags))
                .AfterMap((r, u) => u.UserStatus = (short)UserStatus.Normal);

            CreateMap<MomentAddModel, RpMomentInfo>()
                 .ForMember(r => r.MomentType, u => u.MapFrom(r => (short)r.MomentType))
                 .ForMember(r => r.Scope, u => u.MapFrom(r => (short)r.Scope));


            CreateMap<Attachment, RpPubMedium>()
                .ForMember(r => r.MediaType, u => u.MapFrom(r => (short)r.MediaType))
                .ForMember(r => r.TopicType, u => u.MapFrom(r => (short)r.TopicType));


            CreateMap<WishAddModel, RpWishList>()
                 .ForMember(r => r.RealizeType, u => u.MapFrom(r => (short)r.RealizeType))
                 .ForMember(r => r.WishDescType, u => u.MapFrom(r => (short)r.WishDescType))
                 .ForMember(r => r.WishStatus, u => u.MapFrom(r => (short)r.WishStatus));


            CreateMap<RpMomentInfo, MomentOutput>()
                .ForMember(r => r.MomentType, u => u.MapFrom(r => r.MomentType));

        }



    }
}
