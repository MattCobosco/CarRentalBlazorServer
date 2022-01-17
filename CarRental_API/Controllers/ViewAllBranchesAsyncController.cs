using CoreBusiness;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using UseCases.UseCaseInterfaces.BranchUseCaseInterfaces;

namespace CarRental_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ViewAllBranchesAsyncController : ControllerBase
    {
        private readonly IViewBranchesAsyncUseCase _viewBranchesAsyncUseCase;

        public ViewAllBranchesAsyncController(IViewBranchesAsyncUseCase viewBranchesAsyncUseCase)
        {
            _viewBranchesAsyncUseCase = viewBranchesAsyncUseCase;
        }

        [HttpGet]
        public async Task<IEnumerable<Branch>> ShowAllBranchesDetails()
        {
            return await _viewBranchesAsyncUseCase.Execute();
        }
    }
}
