using CoreBusiness;
using Microsoft.AspNetCore.Mvc;
using UseCases.DataStorePluginInterfaces;

namespace CarRental_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddBranchController : ControllerBase
    {
        private readonly IBranchRepository _branchRepository;

        public AddBranchController(IBranchRepository branchRepository)
        {
            _branchRepository = branchRepository;
        }

        [HttpPost]
        public void AddNewBranch([FromForm] Branch branch)
        { 
            _branchRepository.AddBranch(branch);
        }
    }
}
