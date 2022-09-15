
<configuration>
  <configSections>
    <!-- For more information on Entity Framework configuration, visit http://go.microsoft.com/fwlink/?LinkID=237468 -->
    <section name="entityFramework" type="System.Data.Entity.Internal.ConfigFile.EntityFrameworkSection, EntityFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" requirePermission="false"/>
  </configSections>
  <connectionStrings>
    <!--<add name="AthleteString" connectionString="Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=AthleticManagementSystemDB;Integrated Security=True" providerName="System.Data.SqlClient"/>-->
<add name="AthleteString" connectionString="Data Source=10.142.204.55;Initial Catalog=AthleticManagementSystemDB;User ID=sa;Password=d3vp@ssw0rd" providerName="System.Data.SqlClient" />
<!--<add name="DefaultConnection" connectionString="Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\aspnet-AthleteManagement-WebForm-20191202090657.mdf;Initial Catalog=aspnet-AthleteManagement-WebForm-20191202090657;Integrated Security=True"
      providerName="System.Data.SqlClient" />-->
  </connectionStrings>
