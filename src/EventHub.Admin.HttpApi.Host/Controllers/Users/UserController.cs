﻿using EventHub.Admin.Users;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AspNetCore.Mvc;

namespace EventHub.Admin.Controllers.Users
{
    [RemoteService(Name = EventHubAdminRemoteServiceConsts.RemoteServiceName)]
    [Controller]
    [Area("eventhub-admin")]
    [ControllerName("User")]
    [Route("/api/eventhub/admin/user")]
    public class UserController : AbpController, IUserAppService
    {
        private readonly IUserAppService _userAppService;

        public UserController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        [HttpGet]
        public Task<PagedResultDto<UserDto>> GetUnregisteredUsersOfEventAsync(GetUnregisteredUserEventInput input)
        {
            return _userAppService.GetUnregisteredUsersOfEventAsync(input);
        }
    }
}
