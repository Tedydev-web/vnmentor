using AutoMapper;
using vnmentor.Models;
using System.IO.Packaging;

namespace vnmentor.Utils
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<StudentAnswer, StudentAnswerCloned>();
        }
    }

}
