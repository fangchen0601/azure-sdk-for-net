
// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
  using System;
  using System.Collections.Generic;
  using System.Linq;

  internal static partial class SdkInfo
  {
      public static IEnumerable<Tuple<string, string, string>> ApiInfo_RecoveryServicesBackupClient
      {
          get
          {
              return new Tuple<string, string, string>[]
              {
                new Tuple<string, string, string>("RecoveryServices", "BMSPrepareDataMove", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "BMSPrepareDataMoveOperationResult", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "BMSTriggerDataMove", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "BackupEngines", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "BackupJobs", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "BackupOperationResults", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "BackupOperationStatuses", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "BackupPolicies", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "BackupProtectableItems", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "BackupProtectedItems", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "BackupProtectionContainers", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "BackupProtectionIntent", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "BackupResourceEncryptionConfigs", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "BackupResourceStorageConfigsNonCRR", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "BackupResourceVaultConfigs", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "BackupStatus", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "BackupUsageSummaries", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "BackupWorkloadItems", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "Backups", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "ExportJobsOperationResults", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "FeatureSupport", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "GetOperationStatus", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "ItemLevelRecoveryConnections", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "JobCancellations", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "JobDetails", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "JobOperationResults", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "Jobs", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "MoveRecoveryPoint", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "Operation", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "Operations", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "PrivateEndpoint", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "PrivateEndpointConnection", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "ProtectableContainers", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "ProtectedItemOperationResults", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "ProtectedItemOperationStatuses", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "ProtectedItems", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "ProtectionContainerOperationResults", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "ProtectionContainerRefreshOperationResults", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "ProtectionContainers", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "ProtectionIntent", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "ProtectionPolicies", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "ProtectionPolicyOperationResults", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "ProtectionPolicyOperationStatuses", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "RecoveryPoints", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "RecoveryPointsRecommendedForMove", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "ResourceGuardProxies", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "ResourceGuardProxy", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "Restores", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "SecurityPINs", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "ValidateOperation", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "ValidateOperationResults", "2021-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "ValidateOperationStatuses", "2021-12-01"),
              }.AsEnumerable();
          }
      }
      // BEGIN: Code Generation Metadata Section
      public static readonly String AutoRestVersion = "2.0.4421";
      public static readonly String AutoRestBootStrapperVersion = "autorest@2.0.4413";
      public static readonly String AutoRestCmdExecuted = "cmd.exe /c autorest.cmd https://github.com/Azure/azure-rest-api-specs/blob/main/specification/recoveryservicesbackup/resource-manager/readme.md --csharp --version=2.0.4421 --reflect-api-versions --csharp.namespace=Microsoft.Azure.Management.RecoveryServices.Backup --tag=package-2021-12 --csharp.output-folder=E:\\AzureSDK\\sdk\\recoveryservices-backup\\Microsoft.Azure.Management.RecoveryServices.Backup\\src\\recoveryservicesbackup\\Generated";
      public static readonly String GithubForkName = "Azure";
      public static readonly String GithubBranchName = "main";
      public static readonly String GithubCommidId = "6690ec1649168a1b5b2aadf4aa656de99eefdb23";
      public static readonly String CodeGenerationErrors = "";
      public static readonly String GithubRepoName = "azure-rest-api-specs";
      // END: Code Generation Metadata Section
  }
}

