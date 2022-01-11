using CoreBusiness;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
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
        public async Task<IEnumerable<Branch>> ShowAllBranchesDetails()
        {
            return await _branchRepository.GetBranchesAsync();
        }
    }
}
