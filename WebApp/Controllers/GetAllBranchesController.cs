using CoreBusiness;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UseCases.DataStorePluginInterfaces;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetAllBranchesController : ControllerBase
    {
        private readonly IBranchRepository _branchRepository;

        public GetAllBranchesController(IBranchRepository branchRepository)
        {
            _branchRepository = branchRepository;
        }

        [HttpGet]
        public IEnumerable<Branch> ShowAllBranchesDetails()
        {
            return _branchRepository.GetBranches();
        }
    }
}
