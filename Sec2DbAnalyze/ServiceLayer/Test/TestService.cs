using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Sec2DbAnalyze.Domain.Concrete;
using Sec2DbAnalyze.Dto;
using Sec2DbAnalyze.Dto.Concrete;
using Sec2DbAnalyze.Dto.Concrete.Log;
using Sec2DbAnalyze.Helper.Extensions;
using Sec2DbAnalyze.Persistence.Repository.Abstract.App;
using Sec2DbAnalyze.Persistence.UnitOfWork;
using Sec2DbAnalyze.ServiceLayer.Log;

namespace Sec2DbAnalyze.ServiceLayer.Test
{
    public class TestService : ITestService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserPartitionRepository _userPartitionRepository;
        private readonly IIdentityRepository _identityRepository;
        private readonly ILogService _logService;
        private readonly IUnitOfWork _unitOfWork;

        public TestService(
            IUserRepository userRepository, 
            IIdentityRepository identityRepository,
            ILogService logService, IUnitOfWork unitOfWork, IUserPartitionRepository userPartitionRepository)
        {
            _userRepository = userRepository;
            _identityRepository = identityRepository;
            _logService = logService;
            _unitOfWork = unitOfWork;
            _userPartitionRepository = userPartitionRepository;
        }

        public async Task UpdateUser(UserFilterDto userFilterDto)
        {
            var watch = new Stopwatch();
            var predicate = PredicateExtension.True<User>();

            predicate = predicate.And(x => !x.IsDeleted);

            if (userFilterDto.Id != Guid.Empty)
            {
                predicate = predicate.And(x => x.Id == userFilterDto.Id);
            }
            
            if (!string.IsNullOrEmpty(userFilterDto.Email))
            {
                predicate = predicate.And(x => x.Email.Equals(userFilterDto.Email));
            }
            watch.Start();
            var user = await _userRepository.GetAsync(predicate);
            watch.Stop();
            
            await _logService.Create(new CreateLogDto
            {
                Message = $"Get User Time in Update {watch.ElapsedMilliseconds}",
                Type = "Get User in Update",
                TotalTimeMs = watch.ElapsedMilliseconds
            });

            if (user is not null)
            {
                watch.Reset();
                user.IsActive = false;
                user.Column7 = "Update";
                user.UpdatedDate = DateTime.Now;
                user.Column12 = "Update";

                watch.Start();
                _userRepository.Update(user);
                watch.Stop();
                
                await _logService.Create(new CreateLogDto
                {
                    Message = $"Update User Time {watch.ElapsedMilliseconds}",
                    Type = "Update User",
                    TotalTimeMs = watch.ElapsedMilliseconds
                });
            }
            
            await _unitOfWork.CompleteAsync();
            
        }

        public async Task<bool> GetListUser(UserFilterDto userFilterDto)
        {
            var watch = new Stopwatch();
            var predicate = PredicateExtension.True<User>();

            // predicate = predicate.And(x => !x.IsDeleted);
            //
            // if (userFilterDto.Id != Guid.Empty)
            // {
            //     predicate = predicate.And(x => x.Id == userFilterDto.Id);
            // }
            //
            // if (userFilterDto.AccountId != Guid.Empty)
            // {
            //     predicate = predicate.And(x => x.AccountId == userFilterDto.AccountId);
            // }
            //
            // if (!string.IsNullOrEmpty(userFilterDto.Email))
            // {
            //     predicate = predicate.And(x => x.Email.Equals(userFilterDto.Email));
            // }

            watch.Start();
            //var users = await _userRepository.GetListAsync();
            
            var users = await _userRepository.GetSelectableListAsync(x => new UserDto
            {
                Id = x.Id,
                Name = x.Name,
                Email = x.Email,
                UserProfileId = x.UserProfile.Id,
                UserSectionId = x.UserSection.Id,
                Column28 = x.UserProfile.Column28,
                Column36 = x.UserProfile.Column36,
                Column35 = x.UserSection.Column26,
                Column27 = x.UserSection.Column18
               
            }, null,false, x=>x.UserProfile, x=> x.UserSection, x=> x.Identities);
            
            // var users = await _userRepository.GetSelectableListAsync(x => new UserDto
            // {
            //     Email = x.Email,
            //     Id = x.Id,
            //     Name = x.Name,
            //     Surname = x.Surname,
            //     AccountId = x.AccountId,
            //     ApiKey = x.ApiKey,
            //     BirthDate = x.BirthDate,
            //     IsActive = x.IsActive,
            //     MobilePhone = x.MobilePhone
            // });
            watch.Stop();

            await _logService.Create(new CreateLogDto
            {
                Message = $"Get List User Include 3 Prop and Select 9 Prop Time {watch.ElapsedMilliseconds}",
                Type = "Get User List",
                TotalTimeMs = watch.ElapsedMilliseconds
            });
            await _unitOfWork.CompleteAsync();
            return true;
        }

        public async Task<bool> GetListIdentity(IdentityFilterDto identityFilterDto)
        {
            var watch = new Stopwatch();
            var predicate = PredicateExtension.True<Identity>();

            predicate = predicate.And(x => !x.IsDeleted);

            if (identityFilterDto.Id != Guid.Empty)
            {
                predicate = predicate.And(x => x.Id == identityFilterDto.Id);
            }
            
            if (identityFilterDto.UserId != Guid.Empty)
            {
                predicate = predicate.And(x => x.UserId == identityFilterDto.UserId);
            }
            
            if (identityFilterDto.ServiceId != Guid.Empty)
            {
                predicate = predicate.And(x => x.ServiceId == identityFilterDto.ServiceId);
            }
            
            watch.Start();
            var identities = (await _identityRepository.GetListAsync(predicate)).ToList();
            watch.Stop();
            
            await _logService.Create(new CreateLogDto
            {
                Message = $"Get List Identity Time {watch.ElapsedMilliseconds} - Count {identities.Count}",
                Type = "Get Identity List",
                TotalTimeMs = watch.ElapsedMilliseconds
            });
            await _unitOfWork.CompleteAsync();
            return true;
        }

        public async Task<bool> GetUser(UserFilterDto userFilterDto)
        {
            var watch = new Stopwatch();
            var predicate = PredicateExtension.True<UserPartition>();

            //predicate = predicate.And(x => !x.IsDeleted);

            if (userFilterDto.Id != Guid.Empty)
            {
                predicate = predicate.And(x => x.Id == userFilterDto.Id);
            }
            
            if (!string.IsNullOrEmpty(userFilterDto.Email))
            {
                predicate = predicate.And(x => x.Email.Equals(userFilterDto.Email));
            }

            watch.Start();
            var user = await _userPartitionRepository.GetAsync(predicate);
            watch.Stop();
            
            await _logService.Create(new CreateLogDto
            {
                Message = $"Get User Time Include Account Identity {watch.ElapsedMilliseconds}",
                Type = "Get User",
                TotalTimeMs = watch.ElapsedMilliseconds
            });
            await _unitOfWork.CompleteAsync();
            return true;
        }

        public async Task<bool> GetIdentity(IdentityFilterDto identityFilterDto)
        {
            var watch = new Stopwatch();
            var predicate = PredicateExtension.True<Identity>();

            predicate = predicate.And(x => !x.IsDeleted);

            if (identityFilterDto.Id != Guid.Empty)
            {
                predicate = predicate.And(x => x.Id == identityFilterDto.Id);
            }
            
            watch.Start();
            var identity = await _identityRepository.GetAsync(predicate);
            watch.Stop();
            
            await _logService.Create(new CreateLogDto
            {
                Message = $"Get Identity Time {watch.ElapsedMilliseconds}",
                Type = "Get Identity",
                TotalTimeMs = watch.ElapsedMilliseconds
            });
            await _unitOfWork.CompleteAsync();
            return true;
        }
    }
}