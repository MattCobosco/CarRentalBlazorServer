using CoreBusiness;
using Microsoft.AspNetCore.Mvc;
using UseCases.UseCaseInterfaces.BranchUseCaseInterfaces;

namespace CarRental_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddBranchController : ControllerBase
    {
        private readonly IAddBranchUseCase _addBranchUseCase;

        public AddBranchController(IAddBranchUseCase addBranchUseCase)
        {
            _addBranchUseCase = addBranchUseCase;
        }

        [HttpPost]
        public void AddNewBranch([FromForm] Branch branch)
        {
            _addBranchUseCase.Execute(branch);
        }
    }
}
