using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Sec2DbAnalyze.Domain.Concrete;
using Sec2DbAnalyze.Persistence.Repository.Abstract.App;
using Sec2DbAnalyze.Persistence.UnitOfWork;
using IIdentityPartitionRepository = Sec2DbAnalyze.Persistence.Repository.Abstract.App.IIdentityPartitionRepository;

namespace Sec2DbAnalyze.ServiceLayer.Mock
{
    public class MockService : IMockService
    {
        private readonly IUserRepository _userRepository;
        private readonly IServiceRepository _serviceRepository;
        private readonly IAccountRepository _accountRepository;
        private readonly IIdentityRepository _identityRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<MockService> _logger;
        private readonly ILogRepository _logRepository;
        private readonly IUserProfileRepository _userProfileRepository;
        private readonly IUserSectionRepository _userSectionRepository;
        private readonly IIdentitySectionRepository _identitySectionRepository;
        private readonly IUserPartitionRepository _userPartitionRepository;
        private readonly IIdentityPartitionRepository _identityPartitionRepository;

        public MockService(
            IUserRepository userRepository,
            IServiceRepository serviceRepository,
            IAccountRepository accountRepository,
            IIdentityRepository identityRepository,
            IUnitOfWork unitOfWork,
            ILogger<MockService> logger,
            ILogRepository logRepository,
            IUserProfileRepository userProfileRepository,
            IUserSectionRepository userSectionRepository,
            IIdentitySectionRepository identitySectionRepository, IUserPartitionRepository userPartitionRepository, IIdentityPartitionRepository identityPartitionRepository)
        {
            _userRepository = userRepository;
            _serviceRepository = serviceRepository;
            _accountRepository = accountRepository;
            _identityRepository = identityRepository;
            _unitOfWork = unitOfWork;
            _logger = logger;
            _logRepository = logRepository;
            _userProfileRepository = userProfileRepository;
            _userSectionRepository = userSectionRepository;
            _identitySectionRepository = identitySectionRepository;
            _userPartitionRepository = userPartitionRepository;
            _identityPartitionRepository = identityPartitionRepository;
        }


        public async Task CreateAccountAndService()
        {
            var gen = new Random();
            var accounts = new List<Account>();
            for (int i = 1; i <= 100; i++)
            {
                var newAccount = new Account()
                {
                    Name = $"Name - {i}",
                    Column2 = "SampleValue2",
                    Column3 = "SampleValue3",
                    Column4 = "SampleValue4",
                    Column5 = "SampleValue5",
                    Column6 = "SampleValue6",
                    Column7 = "SampleValue7",
                    Column8 = "SampleValue8",
                    Column9 = "SampleValue9",
                    Column10 = "SampleValue10",
                    Column11 = "SampleValue11",
                    Column12 = "SampleValue12",
                    Column13 = "SampleValue13",
                    Column14 = "SampleValue14",
                    Column15 = "SampleValue15",
                    Column16 = "SampleValue16",
                    Column17 = "SampleValue17",
                    Column18 = "SampleValue18",
                    Column19 = "SampleValue19",
                    Column20 = "SampleValue20",
                    Column21 = "SampleValue21",
                    Column22 = "SampleValue22",
                    Column23 = "SampleValue23",
                    Column24 = "SampleValue24",
                    Column25 = "SampleValue25",
                    Column26 = "SampleValue26",
                    Column27 = "SampleValue27",
                    Column28 = "SampleValue28",
                    Column29 = "SampleValue29",
                    Column30 = "SampleValue30",
                    Column31 = "SampleValue31",
                    Column32 = "SampleValue32",
                    Column33 = "SampleValue33",
                    Column34 = "SampleValue34",
                    Column35 = "SampleValue35",
                    Column36 = "SampleValue36",
                    Column37 = "SampleValue37",
                    Column38 = "SampleValue38",
                    Column39 = "SampleValue39",
                    Column40 = "SampleValue40",
                    Column41 = "SampleValue41",
                    Column42 = "SampleValue42",
                    Column43 = "SampleValue43",
                    Column44 = "SampleValue44",
                    Column45 = "SampleValue45",
                    Column46 = "SampleValue46",
                    Column47 = "SampleValue47",
                    Column48 = "SampleValue48",
                    Column49 = "SampleValue49",
                    Column50 = "SampleValue50",
                    Column51 = "SampleValue51",
                    Column52 = "SampleValue52",
                    Column53 = "SampleValue53",
                    Column54 = "SampleValue54",
                    Column55 = "SampleValue55",
                    Column56 = "SampleValue56",
                    Column57 = "SampleValue57",
                    Column58 = "SampleValue58",
                    Column59 = "SampleValue59",
                    Column60 = "SampleValue60",
                    Column61 = "SampleValue61",
                    Column62 = "SampleValue62",
                    IsDeleted = false
                };
                var addedAccount = await _accountRepository.AddAsync(newAccount);
                accounts.Add(addedAccount);
            }

            for (int i = 1; i <= 1000; i++)
            {
                var newService = new Service()
                {
                    Name = $"Service - {i}",
                    Column2 = "SampleValue2",
                    Column3 = "SampleValue3",
                    Column4 = "SampleValue4",
                    Column5 = "SampleValue5",
                    Column6 = "SampleValue6",
                    Column7 = "SampleValue7",
                    Column8 = "SampleValue8",
                    Column9 = "SampleValue9",
                    Column10 = "SampleValue10",
                    Column11 = "SampleValue11",
                    Column12 = "SampleValue12",
                    Column13 = "SampleValue13",
                    Column14 = "SampleValue14",
                    Column15 = "SampleValue15",
                    Column16 = "SampleValue16",
                    Column17 = "SampleValue17",
                    Column18 = "SampleValue18",
                    Column19 = "SampleValue19",
                    Column20 = "SampleValue20",
                    Column21 = "SampleValue21",
                    Column22 = "SampleValue22",
                    Column23 = "SampleValue23",
                    Column24 = "SampleValue24",
                    Column25 = "SampleValue25",
                    Column26 = "SampleValue26",
                    Column27 = "SampleValue27",
                    Column28 = "SampleValue28",
                    Column29 = "SampleValue29",
                    Column30 = "SampleValue30",
                    Column31 = "SampleValue31",
                    Column32 = "SampleValue32",
                    Column33 = "SampleValue33",
                    Column34 = "SampleValue34",
                    Column35 = "SampleValue35",
                    Column36 = "SampleValue36",
                    Column37 = "SampleValue37",
                    Column38 = "SampleValue38",
                    Column39 = "SampleValue39",
                    Column40 = "SampleValue40",
                    Column41 = "SampleValue41",
                    Column42 = "SampleValue42",
                    Column43 = "SampleValue43",
                    Column44 = "SampleValue44",
                    Column45 = "SampleValue45",
                    Column46 = "SampleValue46",
                    Column47 = "SampleValue47",
                    Column48 = "SampleValue48",
                    Column49 = "SampleValue49",
                    Column50 = "SampleValue50",
                    Column51 = "SampleValue51",
                    Column52 = "SampleValue52",
                    Column53 = "SampleValue53",
                    Column54 = "SampleValue54",
                    Column55 = "SampleValue55",
                    Column56 = "SampleValue56",
                    AccountId = accounts[gen.Next(0, accounts.Count)].Id,
                };
                await _serviceRepository.AddAsync(newService);
            }

            await _unitOfWork.CompleteAsync();
        }

        public async Task CreateMockData(int count)
        {
            var watch = new Stopwatch();
            var gen = new Random();

            var startDate = DateTime.Now;
            _logger.Log(LogLevel.Critical, $"CreateMockData trigerred = {startDate}");
            var accounts = (await _accountRepository.GetListAsync()).ToList();
            var services = (await _serviceRepository.GetListAsync()).ToList();

            var max = count * 10000;

            for (int i = max - 9999; i <= max; i++)
            {
                watch.Reset();
                
                var willAddUser = new UserPartition
                {
                    Name = $"Name - {i}",
                    Surname = $"Surname - {i}",
                    BirthDate = RandomDate(),
                    ApiKey = Guid.NewGuid(),
                    Email = $"user{i + 1}@user.com",
                    MobilePhone = $"{RandomPhone()}",
                    AccountId = accounts[gen.Next(0, accounts.Count)].Id,
                    IsActive = gen.Next(0, 1) == 1,
                    Unit = $"Unit - {i}",
                    Column2 = "SampleValue2",
                    Column3 = "SampleValue3",
                    Column4 = "SampleValue4",
                    Column5 = "SampleValue5",
                    Column6 = "SampleValue6",
                    Column7 = "SampleValue7",
                    Column8 = "SampleValue8",
                    Column9 = "SampleValue9",
                    Column10 = "SampleValue10",
                    Column11 = "SampleValue11",
                    Column12 = "SampleValue12",
                    Column13 = "SampleValue13",
                    Column14 = "SampleValue14",
                    Column15 = "SampleValue15",
                    Column16 = "SampleValue16",
                    Column17 = "SampleValue17",
                    Column18 = "SampleValue18",
                    Column19 = "SampleValue19",
                    Column20 = "SampleValue20",
                    Column21 = "SampleValue21",
                    Column22 = "SampleValue22",
                    Column23 = "SampleValue23",
                    Column24 = "SampleValue24",
                    Column25 = "SampleValue25",
                    Column26 = "SampleValue26",
                    Column27 = "SampleValue27",
                    Column28 = "SampleValue28",
                    Column29 = "SampleValue29",
                    Column30 = "SampleValue30",
                    Column31 = "SampleValue31",
                    Column32 = "SampleValue32",
                    Column33 = "SampleValue33",
                    Column34 = "SampleValue34",
                    Column35 = "SampleValue35",
                    Column36 = "SampleValue36",
                };

                var addedUser = await _userPartitionRepository.AddAsync(willAddUser);


                var identityCount = gen.Next(1, 3);

                var willBeAddedIdentities = new List<IdentityPartition>();
                for (int j = 0; j <= identityCount; j++)
                {
                    var serviceId = services[gen.Next(0, services.Count)].Id;
                    if (willBeAddedIdentities.Any(x => x.ServiceId == serviceId))
                        continue;

                    var willBeAddedIdentity = new IdentityPartition()
                    {
                        UserPartitionId = addedUser.Id,
                        ServiceId = serviceId,
                        Column2 = "SampleValue2",
                        Column3 = "SampleValue3",
                        Column4 = "SampleValue4",
                        Column5 = "SampleValue5",
                        Column6 = "SampleValue6",
                        Column7 = "SampleValue7",
                        Column8 = "SampleValue8",
                        Column9 = "SampleValue9",
                        Column10 = "SampleValue10",
                        Column11 = "SampleValue11",
                        Column12 = "SampleValue12",
                        Column13 = "SampleValue13",
                        Column14 = "SampleValue14",
                        Column15 = "SampleValue15",
                        Column16 = "SampleValue16",
                        Column17 = "SampleValue17",
                        Column18 = "SampleValue18",
                        Column19 = "SampleValue19",
                        Column20 = "SampleValue20",
                        Column21 = "SampleValue21",
                        Column22 = "SampleValue22",
                        Column23 = "SampleValue23",
                        Column24 = "SampleValue24",
                        Column25 = "SampleValue25",
                    };
                    willBeAddedIdentities.Add(willBeAddedIdentity);
                }

                await _identityPartitionRepository.AddRangeAsync(willBeAddedIdentities);
            }
            
            watch.Start();
            await _unitOfWork.CompleteAsync();
            watch.Stop();

            await _logRepository.AddAsync(new Domain.Concrete.Log
            {
                Message = $"Complete async done {watch.ElapsedMilliseconds}",
                Type = "User,Identity",
                TotalTimeMs = watch.ElapsedMilliseconds,
                CreatedAt = DateTime.Now
            });

            await _unitOfWork.CompleteAsync();
            _logger.Log(LogLevel.Critical, $"Start Time = {startDate} and End Time = {DateTime.Now}");
        }

        public async Task CreatePartialMockDate(int count)
        {
            var watch = new Stopwatch();
            var gen = new Random();

            var startDate = DateTime.Now;
            _logger.Log(LogLevel.Critical, $"CreateMockData trigerred = {startDate}");
            var accounts = (await _accountRepository.GetListAsync()).ToList();
            var services = (await _serviceRepository.GetListAsync()).ToList();

            var max = count * 10000;

            for (int i = max - 9999; i <= max; i++)
            {
                watch.Reset();

                var willAddUserProfile = new UserProfile
                {
                    Column27 = "SampleValue27",
                    Column28 = "SampleValue28",
                    Column29 = "SampleValue29",
                    Column30 = "SampleValue30",
                    Column31 = "SampleValue31",
                    Column32 = "SampleValue32",
                    Column33 = "SampleValue33",
                    Column34 = "SampleValue34",
                    Column35 = "SampleValue35",
                    Column36 = "SampleValue36",
                };

                var addedUserProfile = await _userProfileRepository.AddAsync(willAddUserProfile);

                var willAddUserSection = new UserSection
                {
                    Column15 = "SampleValue15",
                    Column16 = "SampleValue16",
                    Column17 = "SampleValue17",
                    Column18 = "SampleValue18",
                    Column19 = "SampleValue19",
                    Column20 = "SampleValue20",
                    Column21 = "SampleValue21",
                    Column22 = "SampleValue22",
                    Column23 = "SampleValue23",
                    Column24 = "SampleValue24",
                    Column25 = "SampleValue25",
                    Column26 = "SampleValue26",
                };

                var addedUserSection = await _userSectionRepository.AddAsync(willAddUserSection);

                var willAddUser = new User
                {
                    Name = $"Name - {i}",
                    Surname = $"Surname - {i}",
                    BirthDate = RandomDate(),
                    ApiKey = Guid.NewGuid(),
                    Email = $"user{i + 1}@user.com",
                    MobilePhone = $"{RandomPhone()}",
                    AccountId = accounts[gen.Next(0, accounts.Count)].Id,
                    IsActive = gen.Next(0, 1) == 1,
                    Unit = $"Unit - {i}",
                    Column2 = "SampleValue2",
                    Column3 = "SampleValue3",
                    Column4 = "SampleValue4",
                    Column5 = "SampleValue5",
                    Column6 = "SampleValue6",
                    Column7 = "SampleValue7",
                    Column8 = "SampleValue8",
                    Column9 = "SampleValue9",
                    Column10 = "SampleValue10",
                    Column11 = "SampleValue11",
                    Column12 = "SampleValue12",
                    Column13 = "SampleValue13",
                    Column14 = "SampleValue14",
                    UserSectionId = willAddUserSection.Id,
                    UserProfileId = willAddUserProfile.Id,
                };

                var addedUser = await _userRepository.AddAsync(willAddUser);


                var identityCount = gen.Next(1, 3);

                var willBeAddedIdentitySection = new IdentitySection
                {
                    Column15 = "SampleValue15",
                    Column16 = "SampleValue16",
                    Column17 = "SampleValue17",
                    Column18 = "SampleValue18",
                    Column19 = "SampleValue19",
                    Column20 = "SampleValue20",
                    Column21 = "SampleValue21",
                    Column22 = "SampleValue22",
                    Column23 = "SampleValue23",
                    Column24 = "SampleValue24",
                    Column25 = "SampleValue25",
                };

                var addedIdentitySection = await _identitySectionRepository.AddAsync(willBeAddedIdentitySection);

                var willBeAddedIdentities = new List<Identity>();
                for (int j = 0; j <= identityCount; j++)
                {
                    var serviceId = services[gen.Next(0, services.Count)].Id;
                    if (willBeAddedIdentities.Any(x => x.ServiceId == serviceId))
                        continue;

                    var addedUserAddress = new Identity()
                    {
                        UserId = addedUser.Id,
                        ServiceId = serviceId,
                        Column2 = "SampleValue2",
                        Column3 = "SampleValue3",
                        Column4 = "SampleValue4",
                        Column5 = "SampleValue5",
                        Column6 = "SampleValue6",
                        Column7 = "SampleValue7",
                        Column8 = "SampleValue8",
                        Column9 = "SampleValue9",
                        Column10 = "SampleValue10",
                        Column11 = "SampleValue11",
                        Column12 = "SampleValue12",
                        Column13 = "SampleValue13",
                        Column14 = "SampleValue14",
                        IdentitySectionId = addedIdentitySection.Id
                    };
                    willBeAddedIdentities.Add(addedUserAddress);
                }

                await _identityRepository.AddRangeAsync(willBeAddedIdentities);
            }
            
            watch.Start();
            await _unitOfWork.CompleteAsync();
            watch.Stop();

            await _logRepository.AddAsync(new Domain.Concrete.Log
            {
                Message = $"Complete async done after normalization {watch.ElapsedMilliseconds}",
                Type = "User,Identity",
                TotalTimeMs = watch.ElapsedMilliseconds,
                CreatedAt = DateTime.Now
            });

            await _unitOfWork.CompleteAsync();

            _logger.Log(LogLevel.Critical, $"Start Time = {startDate} and End Time = {DateTime.Now}");
        }


        private DateTime RandomDate()
        {
            var gen = new Random();
            var start = new DateTime(1970, 1, 1);
            var range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }

        private int RandomPhone()
        {
            var gen = new Random();
            return gen.Next(1000000, 9999999);
        }
    }
}