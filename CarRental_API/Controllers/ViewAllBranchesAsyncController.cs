using System.Collections.Generic;
using System.Threading.Tasks;
using CoreBusiness;
using Microsoft.AspNetCore.Mvc;
using UseCases.DataStorePluginInterfaces;

namespace CarRental_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ViewAllBranchesAsyncController : ControllerBase
    {
        private readonly IBranchRepository _branchRepository;

        public ViewAllBranchesAsyncController(IBranchRepository branchRepository)
        {
            _branchRepository = branchRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Branch>> ShowAllBranchesDetails()
        {
            return await _branchRepository.ViewBranchesAsync();
        }
    }
}
