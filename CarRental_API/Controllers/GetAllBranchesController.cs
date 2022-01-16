using CoreBusiness;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace CarRental_UI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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
            return await _branchRepository.ViewBranchesAsync();
        }
    }
}
