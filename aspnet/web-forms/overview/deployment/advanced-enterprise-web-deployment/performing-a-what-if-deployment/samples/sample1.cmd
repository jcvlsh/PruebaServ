MSDeploy.exe
  -whatif
  -source:package="[path]\ContactManager.Mvc.zip"
  -dest:auto,
        computerName="https://stageweb1:8172/MSDeploy.axd?site=DemoSite",
        username="FABRIKAM\stagingdeployer",
        password="Pa$$w0rd",
        authtype="Basic",
        includeAcls="False"
  -verb:sync
  -disableLink:AppPoolExtension
  -disableLink:ContentExtension
  -disableLink:CertificateExtension
  -setParamFile:"[path]\ContactManager.Mvc.SetParameters.xml"
  -allowUntrusted
