using System.Collections.Generic;
using Microsoft.TemplateEngine.Abstractions;

namespace Microsoft.TemplateEngine.Cli
{
    public interface IInstaller : IInstallerBase
    {
        void InstallPackages(IEnumerable<string> installationRequests, IList<string> nuGetSources);

        void InstallPackages(IEnumerable<string> installationRequests, IList<string> nuGetSources, bool debugAllowDevInstall);

        void InstallPackages(IEnumerable<string> installationRequests, IList<string> nuGetSources, bool debugAllowDevInstall, bool interactive);

        void InstallPackages(IEnumerable<InstallationRequest> installationRequests, IList<string> nuGetSources = null, bool debugAllowDevInstall = false, bool interactive = false);
    }
}
