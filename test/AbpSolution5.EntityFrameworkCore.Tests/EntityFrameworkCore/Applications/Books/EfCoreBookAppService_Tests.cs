using AbpSolution5.Books;
using Xunit;

namespace AbpSolution5.EntityFrameworkCore.Applications.Books;

[Collection(AbpSolution5TestConsts.CollectionDefinitionName)]
public class EfCoreBookAppService_Tests : BookAppService_Tests<AbpSolution5EntityFrameworkCoreTestModule>
{

}