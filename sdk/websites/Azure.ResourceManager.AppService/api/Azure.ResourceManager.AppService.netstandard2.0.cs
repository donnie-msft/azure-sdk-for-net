namespace Azure.ResourceManager.AppService
{
    public partial class AnalysisDefinitionData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public AnalysisDefinitionData() { }
        public string Description { get { throw null; } }
    }
    public partial class ApiKeyVaultReferenceData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public ApiKeyVaultReferenceData() { }
        public string ActiveVersion { get { throw null; } set { } }
        public string Details { get { throw null; } set { } }
        public Azure.ResourceManager.Models.ManagedServiceIdentity IdentityType { get { throw null; } set { } }
        public string Reference { get { throw null; } set { } }
        public string SecretName { get { throw null; } set { } }
        public string SecretVersion { get { throw null; } set { } }
        public string Source { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.ResolveStatus? Status { get { throw null; } set { } }
        public string VaultName { get { throw null; } set { } }
    }
    public partial class AppServiceCertificateOrder : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected AppServiceCertificateOrder() { }
        public virtual Azure.ResourceManager.AppService.AppServiceCertificateOrderData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.AppService.AppServiceCertificateOrder> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.AppServiceCertificateOrder>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string certificateOrderName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.AppServiceCertificateOrder> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.AppServiceCertificateResource> GetAppServiceCertificateResource(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.AppServiceCertificateResource>> GetAppServiceCertificateResourceAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.AppServiceCertificateResourceCollection GetAppServiceCertificateResources() { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.AppServiceCertificateOrder>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.CertificateOrderDetector> GetCertificateOrderDetector(string detectorName, System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.CertificateOrderDetector>> GetCertificateOrderDetectorAsync(string detectorName, System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.CertificateOrderDetectorCollection GetCertificateOrderDetectors() { throw null; }
        public virtual Azure.Response Reissue(Azure.ResourceManager.AppService.Models.ReissueCertificateOrderRequest reissueCertificateOrderRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> ReissueAsync(Azure.ResourceManager.AppService.Models.ReissueCertificateOrderRequest reissueCertificateOrderRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.AppServiceCertificateOrder> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.AppServiceCertificateOrder>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response Renew(Azure.ResourceManager.AppService.Models.RenewCertificateOrderRequest renewCertificateOrderRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> RenewAsync(Azure.ResourceManager.AppService.Models.RenewCertificateOrderRequest renewCertificateOrderRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response ResendEmail(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> ResendEmailAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response ResendRequestEmails(Azure.ResourceManager.AppService.Models.NameIdentifier nameIdentifier, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> ResendRequestEmailsAsync(Azure.ResourceManager.AppService.Models.NameIdentifier nameIdentifier, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.CertificateOrderAction> RetrieveCertificateActions(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.CertificateOrderAction> RetrieveCertificateActionsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.CertificateEmail> RetrieveCertificateEmailHistory(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.CertificateEmail> RetrieveCertificateEmailHistoryAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.SiteSeal> RetrieveSiteSeal(Azure.ResourceManager.AppService.Models.SiteSealRequest siteSealRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.SiteSeal>> RetrieveSiteSealAsync(Azure.ResourceManager.AppService.Models.SiteSealRequest siteSealRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.AppServiceCertificateOrder> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.AppServiceCertificateOrder>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.AppServiceCertificateOrder> Update(Azure.ResourceManager.AppService.Models.PatchableAppServiceCertificateOrderData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.AppServiceCertificateOrder>> UpdateAsync(Azure.ResourceManager.AppService.Models.PatchableAppServiceCertificateOrderData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response VerifyDomainOwnership(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> VerifyDomainOwnershipAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class AppServiceCertificateOrderCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.AppServiceCertificateOrder>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.AppServiceCertificateOrder>, System.Collections.IEnumerable
    {
        protected AppServiceCertificateOrderCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.AppServiceCertificateOrder> CreateOrUpdate(Azure.WaitUntil waitUntil, string certificateOrderName, Azure.ResourceManager.AppService.AppServiceCertificateOrderData certificateDistinguishedName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.AppServiceCertificateOrder>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string certificateOrderName, Azure.ResourceManager.AppService.AppServiceCertificateOrderData certificateDistinguishedName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string certificateOrderName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string certificateOrderName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.AppServiceCertificateOrder> Get(string certificateOrderName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.AppServiceCertificateOrder> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.AppServiceCertificateOrder> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.AppServiceCertificateOrder>> GetAsync(string certificateOrderName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.AppServiceCertificateOrder> GetIfExists(string certificateOrderName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.AppServiceCertificateOrder>> GetIfExistsAsync(string certificateOrderName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.AppServiceCertificateOrder> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.AppServiceCertificateOrder>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.AppServiceCertificateOrder> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.AppServiceCertificateOrder>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class AppServiceCertificateOrderData : Azure.ResourceManager.AppService.Models.AppServiceResource
    {
        public AppServiceCertificateOrderData(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppService.Models.AppServiceCertificateNotRenewableReason> AppServiceCertificateNotRenewableReasons { get { throw null; } }
        public bool? AutoRenew { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, Azure.ResourceManager.AppService.Models.AppServiceCertificate> Certificates { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.CertificateOrderContact Contact { get { throw null; } }
        public string Csr { get { throw null; } set { } }
        public string DistinguishedName { get { throw null; } set { } }
        public string DomainVerificationToken { get { throw null; } }
        public System.DateTimeOffset? ExpirationTime { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.CertificateDetails Intermediate { get { throw null; } }
        public bool? IsPrivateKeyExternal { get { throw null; } }
        public int? KeySize { get { throw null; } set { } }
        public System.DateTimeOffset? LastCertificateIssuanceTime { get { throw null; } }
        public System.DateTimeOffset? NextAutoRenewalTimeStamp { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.CertificateProductType? ProductType { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.CertificateDetails Root { get { throw null; } }
        public string SerialNumber { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.CertificateDetails SignedCertificate { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.CertificateOrderStatus? Status { get { throw null; } }
        public int? ValidityInYears { get { throw null; } set { } }
    }
    public partial class AppServiceCertificateResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected AppServiceCertificateResource() { }
        public virtual Azure.ResourceManager.AppService.AppServiceCertificateResourceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.AppService.AppServiceCertificateResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.AppServiceCertificateResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string certificateOrderName, string name) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.AppServiceCertificateResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.AppServiceCertificateResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.AppServiceCertificateResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.AppServiceCertificateResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.AppServiceCertificateResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.AppServiceCertificateResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.AppServiceCertificateResource> Update(Azure.ResourceManager.AppService.Models.PatchableAppServiceCertificateResourceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.AppServiceCertificateResource>> UpdateAsync(Azure.ResourceManager.AppService.Models.PatchableAppServiceCertificateResourceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class AppServiceCertificateResourceCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.AppServiceCertificateResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.AppServiceCertificateResource>, System.Collections.IEnumerable
    {
        protected AppServiceCertificateResourceCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.AppServiceCertificateResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string name, Azure.ResourceManager.AppService.AppServiceCertificateResourceData keyVaultCertificate, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.AppServiceCertificateResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string name, Azure.ResourceManager.AppService.AppServiceCertificateResourceData keyVaultCertificate, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.AppServiceCertificateResource> Get(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.AppServiceCertificateResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.AppServiceCertificateResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.AppServiceCertificateResource>> GetAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.AppServiceCertificateResource> GetIfExists(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.AppServiceCertificateResource>> GetIfExistsAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.AppServiceCertificateResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.AppServiceCertificateResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.AppServiceCertificateResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.AppServiceCertificateResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class AppServiceCertificateResourceData : Azure.ResourceManager.AppService.Models.AppServiceResource
    {
        public AppServiceCertificateResourceData(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public string KeyVaultId { get { throw null; } set { } }
        public string KeyVaultSecretName { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.KeyVaultSecretStatus? ProvisioningState { get { throw null; } }
    }
    public partial class AppServiceDetectorData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public AppServiceDetectorData() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.DataProviderMetadata> DataProvidersMetadata { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.DiagnosticData> Dataset { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.DetectorInfo Metadata { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.OperationStatusAutoGenerated Status { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.QueryUtterancesResults SuggestedUtterances { get { throw null; } set { } }
    }
    public partial class AppServiceDomain : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected AppServiceDomain() { }
        public virtual Azure.ResourceManager.AppService.AppServiceDomainData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.AppService.AppServiceDomain> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.AppServiceDomain>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string domainName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, bool? forceHardDeleteDomain = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, bool? forceHardDeleteDomain = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.AppServiceDomain> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.AppServiceDomain>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.DomainOwnershipIdentifier> GetDomainOwnershipIdentifier(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.DomainOwnershipIdentifier>> GetDomainOwnershipIdentifierAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.DomainOwnershipIdentifierCollection GetDomainOwnershipIdentifiers() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.AppServiceDomain> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.AppServiceDomain>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response Renew(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> RenewAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.AppServiceDomain> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.AppServiceDomain>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.AppServiceDomain> Update(Azure.ResourceManager.AppService.Models.PatchableAppServiceDomainData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.AppServiceDomain>> UpdateAsync(Azure.ResourceManager.AppService.Models.PatchableAppServiceDomainData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class AppServiceDomainCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.AppServiceDomain>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.AppServiceDomain>, System.Collections.IEnumerable
    {
        protected AppServiceDomainCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.AppServiceDomain> CreateOrUpdate(Azure.WaitUntil waitUntil, string domainName, Azure.ResourceManager.AppService.AppServiceDomainData domain, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.AppServiceDomain>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string domainName, Azure.ResourceManager.AppService.AppServiceDomainData domain, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string domainName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string domainName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.AppServiceDomain> Get(string domainName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.AppServiceDomain> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.AppServiceDomain> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.AppServiceDomain>> GetAsync(string domainName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.AppServiceDomain> GetIfExists(string domainName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.AppServiceDomain>> GetIfExistsAsync(string domainName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.AppServiceDomain> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.AppServiceDomain>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.AppServiceDomain> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.AppServiceDomain>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class AppServiceDomainData : Azure.ResourceManager.AppService.Models.AppServiceResource
    {
        public AppServiceDomainData(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public string AuthCode { get { throw null; } set { } }
        public bool? AutoRenew { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.DomainPurchaseConsent Consent { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.ContactInformation ContactAdmin { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.ContactInformation ContactBilling { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.ContactInformation ContactRegistrant { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.ContactInformation ContactTech { get { throw null; } set { } }
        public System.DateTimeOffset? CreatedTime { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.DnsType? DnsType { get { throw null; } set { } }
        public string DnsZoneId { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppService.Models.AppServiceDomainPropertiesDomainNotRenewableReasonsItem> DomainNotRenewableReasons { get { throw null; } }
        public System.DateTimeOffset? ExpirationTime { get { throw null; } }
        public System.DateTimeOffset? LastRenewedTime { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppService.Models.HostName> ManagedHostNames { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> NameServers { get { throw null; } }
        public bool? Privacy { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public bool? ReadyForDnsRecordManagement { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.DomainStatus? RegistrationStatus { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.DnsType? TargetDnsType { get { throw null; } set { } }
    }
    public partial class AppServiceEnvironment : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected AppServiceEnvironment() { }
        public virtual Azure.ResourceManager.AppService.AppServiceEnvironmentData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.AppService.AppServiceEnvironment> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.AppServiceEnvironment>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, bool? forceDelete = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, bool? forceDelete = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DisableAllForHostingEnvironmentRecommendation(string environmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DisableAllForHostingEnvironmentRecommendationAsync(string environmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.AppServiceEnvironment> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.AppServicePlan> GetAppServicePlans(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.AppServicePlan> GetAppServicePlansAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.AseV3NetworkingConfiguration GetAseV3NetworkingConfiguration() { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.AppServiceEnvironment>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.StampCapacity> GetCapacities(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.StampCapacity> GetCapacitiesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.HostingEnvironmentDiagnostics> GetDiagnostics(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.HostingEnvironmentDiagnostics> GetDiagnosticsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.HostingEnvironmentDiagnostics> GetDiagnosticsItem(string diagnosticsName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.HostingEnvironmentDiagnostics>> GetDiagnosticsItemAsync(string diagnosticsName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.AppServiceRecommendation> GetHistoryForHostingEnvironmentRecommendations(bool? expiredOnly = default(bool?), string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.AppServiceRecommendation> GetHistoryForHostingEnvironmentRecommendationsAsync(bool? expiredOnly = default(bool?), string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.HostingEnvironmentDetector> GetHostingEnvironmentDetector(string detectorName, System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.HostingEnvironmentDetector>> GetHostingEnvironmentDetectorAsync(string detectorName, System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.HostingEnvironmentDetectorCollection GetHostingEnvironmentDetectors() { throw null; }
        public virtual Azure.ResourceManager.AppService.HostingEnvironmentMultiRolePool GetHostingEnvironmentMultiRolePool() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.HostingEnvironmentPrivateEndpointConnection> GetHostingEnvironmentPrivateEndpointConnection(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.HostingEnvironmentPrivateEndpointConnection>> GetHostingEnvironmentPrivateEndpointConnectionAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.HostingEnvironmentPrivateEndpointConnectionCollection GetHostingEnvironmentPrivateEndpointConnections() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.HostingEnvironmentRecommendation> GetHostingEnvironmentRecommendation(string name, bool? updateSeen = default(bool?), string recommendationId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.HostingEnvironmentRecommendation>> GetHostingEnvironmentRecommendationAsync(string name, bool? updateSeen = default(bool?), string recommendationId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.HostingEnvironmentRecommendationCollection GetHostingEnvironmentRecommendations() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.HostingEnvironmentWorkerPool> GetHostingEnvironmentWorkerPool(string workerPoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.HostingEnvironmentWorkerPool>> GetHostingEnvironmentWorkerPoolAsync(string workerPoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.HostingEnvironmentWorkerPoolCollection GetHostingEnvironmentWorkerPools() { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.InboundEnvironmentEndpoint> GetInboundNetworkDependenciesEndpoints(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.InboundEnvironmentEndpoint> GetInboundNetworkDependenciesEndpointsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.OperationInformation> GetOperations(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.OperationInformation> GetOperationsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.OutboundEnvironmentEndpoint> GetOutboundNetworkDependenciesEndpoints(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.OutboundEnvironmentEndpoint> GetOutboundNetworkDependenciesEndpointsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.PrivateLinkResource> GetPrivateLinkResources(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.PrivateLinkResource> GetPrivateLinkResourcesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.AppServiceRecommendation> GetRecommendedRulesForHostingEnvironmentRecommendations(bool? featured = default(bool?), string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.AppServiceRecommendation> GetRecommendedRulesForHostingEnvironmentRecommendationsAsync(bool? featured = default(bool?), string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.CsmUsageQuota> GetUsages(string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.CsmUsageQuota> GetUsagesAsync(string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.AddressResponse> GetVipInfo(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.AddressResponse>> GetVipInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.WebSite> GetWebApps(string propertiesToInclude = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.WebSite> GetWebAppsAsync(string propertiesToInclude = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response Reboot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> RebootAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.AppServiceEnvironment> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.AppServiceEnvironment>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response ResetAllFiltersForHostingEnvironmentRecommendation(string environmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> ResetAllFiltersForHostingEnvironmentRecommendationAsync(string environmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.AppServiceEnvironment> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.AppServiceEnvironment>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.AppServiceEnvironment> Update(Azure.ResourceManager.AppService.Models.PatchableAppServiceEnvironmentData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.AppServiceEnvironment>> UpdateAsync(Azure.ResourceManager.AppService.Models.PatchableAppServiceEnvironmentData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class AppServiceEnvironmentCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.AppServiceEnvironment>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.AppServiceEnvironment>, System.Collections.IEnumerable
    {
        protected AppServiceEnvironmentCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.AppServiceEnvironment> CreateOrUpdate(Azure.WaitUntil waitUntil, string name, Azure.ResourceManager.AppService.AppServiceEnvironmentData hostingEnvironmentEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.AppServiceEnvironment>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string name, Azure.ResourceManager.AppService.AppServiceEnvironmentData hostingEnvironmentEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.AppServiceEnvironment> Get(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.AppServiceEnvironment> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.AppServiceEnvironment> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.AppServiceEnvironment>> GetAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.AppServiceEnvironment> GetIfExists(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.AppServiceEnvironment>> GetIfExistsAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.AppServiceEnvironment> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.AppServiceEnvironment>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.AppServiceEnvironment> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.AppServiceEnvironment>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class AppServiceEnvironmentData : Azure.ResourceManager.AppService.Models.AppServiceResource
    {
        public AppServiceEnvironmentData(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.NameValuePair> ClusterSettings { get { throw null; } }
        public int? DedicatedHostCount { get { throw null; } set { } }
        public string DnsSuffix { get { throw null; } set { } }
        public int? FrontEndScaleFactor { get { throw null; } set { } }
        public bool? HasLinuxWorkers { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.LoadBalancingMode? InternalLoadBalancingMode { get { throw null; } set { } }
        public int? IpsslAddressCount { get { throw null; } set { } }
        public int? MaximumNumberOfMachines { get { throw null; } }
        public int? MultiRoleCount { get { throw null; } }
        public string MultiSize { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.HostingEnvironmentStatus? Status { get { throw null; } }
        public bool? Suspended { get { throw null; } }
        public System.Collections.Generic.IList<string> UserWhitelistedIpRanges { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.VirtualNetworkProfile VirtualNetwork { get { throw null; } set { } }
        public bool? ZoneRedundant { get { throw null; } set { } }
    }
    public static partial class AppServiceExtensions
    {
        public static Azure.Response<Azure.ResourceManager.AppService.Models.ResourceNameAvailability> CheckAppServiceNameAvailability(this Azure.ResourceManager.Resources.Subscription subscription, string name, Azure.ResourceManager.AppService.Models.CheckNameResourceTypes type, bool? isFqdn = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.ResourceNameAvailability>> CheckAppServiceNameAvailabilityAsync(this Azure.ResourceManager.Resources.Subscription subscription, string name, Azure.ResourceManager.AppService.Models.CheckNameResourceTypes type, bool? isFqdn = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.AppService.Models.DomainAvailabilityCheckResult> CheckAvailabilityDomain(this Azure.ResourceManager.Resources.Subscription subscription, Azure.ResourceManager.AppService.Models.NameIdentifier identifier, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.DomainAvailabilityCheckResult>> CheckAvailabilityDomainAsync(this Azure.ResourceManager.Resources.Subscription subscription, Azure.ResourceManager.AppService.Models.NameIdentifier identifier, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response DisableRecommendationForSubscriptionRecommendation(this Azure.ResourceManager.Resources.Subscription subscription, string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response> DisableRecommendationForSubscriptionRecommendationAsync(this Azure.ResourceManager.Resources.Subscription subscription, string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.AppService.SiteResourceHealthMetadata> GetAllResourceHealthMetadata(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.AppService.SiteResourceHealthMetadata> GetAllResourceHealthMetadata(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteResourceHealthMetadata> GetAllResourceHealthMetadataAsync(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteResourceHealthMetadata> GetAllResourceHealthMetadataAsync(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.AppService.AppServiceCertificateOrder GetAppServiceCertificateOrder(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.AppService.AppServiceCertificateOrder> GetAppServiceCertificateOrder(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup, string certificateOrderName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.AppServiceCertificateOrder>> GetAppServiceCertificateOrderAsync(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup, string certificateOrderName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.AppService.AppServiceCertificateOrderCollection GetAppServiceCertificateOrders(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.AppService.AppServiceCertificateOrder> GetAppServiceCertificateOrders(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.AppService.AppServiceCertificateOrder> GetAppServiceCertificateOrdersAsync(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.AppService.AppServiceCertificateResource GetAppServiceCertificateResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.AppServiceDomain GetAppServiceDomain(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.AppService.AppServiceDomain> GetAppServiceDomain(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup, string domainName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.AppServiceDomain>> GetAppServiceDomainAsync(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup, string domainName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.AppService.AppServiceDomainCollection GetAppServiceDomains(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.AppService.AppServiceDomain> GetAppServiceDomains(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.AppService.AppServiceDomain> GetAppServiceDomainsAsync(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.AppService.AppServiceEnvironment GetAppServiceEnvironment(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.AppService.AppServiceEnvironment> GetAppServiceEnvironment(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup, string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.AppServiceEnvironment>> GetAppServiceEnvironmentAsync(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup, string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.AppService.AppServiceEnvironmentCollection GetAppServiceEnvironments(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.AppService.AppServiceEnvironment> GetAppServiceEnvironments(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.AppService.AppServiceEnvironment> GetAppServiceEnvironmentsAsync(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.AppService.AppServicePlan GetAppServicePlan(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.AppService.AppServicePlan> GetAppServicePlan(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup, string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.AppServicePlan>> GetAppServicePlanAsync(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup, string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.AppService.AppServicePlanCollection GetAppServicePlans(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.AppService.AppServicePlan> GetAppServicePlans(this Azure.ResourceManager.Resources.Subscription subscription, bool? detailed = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.AppService.AppServicePlan> GetAppServicePlansAsync(this Azure.ResourceManager.Resources.Subscription subscription, bool? detailed = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.AppService.AseV3NetworkingConfiguration GetAseV3NetworkingConfiguration(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.AppService.Models.ApplicationStackResource> GetAvailableStacksOnPremProviders(this Azure.ResourceManager.Resources.Subscription subscription, Azure.ResourceManager.AppService.Models.ProviderOsTypeSelected? osTypeSelected = default(Azure.ResourceManager.AppService.Models.ProviderOsTypeSelected?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.ApplicationStackResource> GetAvailableStacksOnPremProvidersAsync(this Azure.ResourceManager.Resources.Subscription subscription, Azure.ResourceManager.AppService.Models.ProviderOsTypeSelected? osTypeSelected = default(Azure.ResourceManager.AppService.Models.ProviderOsTypeSelected?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.AppService.Models.ApplicationStackResource> GetAvailableStacksProviders(this Azure.ResourceManager.Resources.Tenant tenant, Azure.ResourceManager.AppService.Models.ProviderOsTypeSelected? osTypeSelected = default(Azure.ResourceManager.AppService.Models.ProviderOsTypeSelected?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.ApplicationStackResource> GetAvailableStacksProvidersAsync(this Azure.ResourceManager.Resources.Tenant tenant, Azure.ResourceManager.AppService.Models.ProviderOsTypeSelected? osTypeSelected = default(Azure.ResourceManager.AppService.Models.ProviderOsTypeSelected?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.AppService.BasicPublishingCredentialsPolicyFtp GetBasicPublishingCredentialsPolicyFtp(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.AppService.Models.BillingMeter> GetBillingMeters(this Azure.ResourceManager.Resources.Subscription subscription, string billingLocation = null, string osType = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.BillingMeter> GetBillingMetersAsync(this Azure.ResourceManager.Resources.Subscription subscription, string billingLocation = null, string osType = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.AppService.Certificate GetCertificate(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.AppService.Certificate> GetCertificate(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup, string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Certificate>> GetCertificateAsync(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup, string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.AppService.CertificateOrderDetector GetCertificateOrderDetector(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.CertificateCollection GetCertificates(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.AppService.Certificate> GetCertificates(this Azure.ResourceManager.Resources.Subscription subscription, string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.AppService.Certificate> GetCertificatesAsync(this Azure.ResourceManager.Resources.Subscription subscription, string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.AppService.Models.DomainControlCenterSsoRequest> GetControlCenterSsoRequestDomain(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.DomainControlCenterSsoRequest>> GetControlCenterSsoRequestDomainAsync(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.AppService.DeletedSite GetDeletedSite(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.AppService.DeletedSite> GetDeletedSite(this Azure.ResourceManager.Resources.Subscription subscription, string deletedSiteId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.DeletedSite>> GetDeletedSiteAsync(this Azure.ResourceManager.Resources.Subscription subscription, string deletedSiteId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.AppService.DeletedSiteCollection GetDeletedSites(this Azure.ResourceManager.Resources.Subscription subscription) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.AppService.DeletedSite> GetDeletedSitesByLocation(this Azure.ResourceManager.Resources.Subscription subscription, string location, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.AppService.DeletedSite> GetDeletedSitesByLocationAsync(this Azure.ResourceManager.Resources.Subscription subscription, string location, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.AppService.DeletedSite> GetDeletedWebAppByLocationDeletedWebApp(this Azure.ResourceManager.Resources.Subscription subscription, string location, string deletedSiteId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.DeletedSite>> GetDeletedWebAppByLocationDeletedWebAppAsync(this Azure.ResourceManager.Resources.Subscription subscription, string location, string deletedSiteId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.AppService.DomainOwnershipIdentifier GetDomainOwnershipIdentifier(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.FtpSiteSlotBasicPublishingCredentialsPolicy GetFtpSiteSlotBasicPublishingCredentialsPolicy(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.AppService.Models.FunctionAppStack> GetFunctionAppStacksForLocationProviders(this Azure.ResourceManager.Resources.Tenant tenant, string location, Azure.ResourceManager.AppService.Models.ProviderStackOsType? stackOsType = default(Azure.ResourceManager.AppService.Models.ProviderStackOsType?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.FunctionAppStack> GetFunctionAppStacksForLocationProvidersAsync(this Azure.ResourceManager.Resources.Tenant tenant, string location, Azure.ResourceManager.AppService.Models.ProviderStackOsType? stackOsType = default(Azure.ResourceManager.AppService.Models.ProviderStackOsType?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.AppService.Models.FunctionAppStack> GetFunctionAppStacksProviders(this Azure.ResourceManager.Resources.Tenant tenant, Azure.ResourceManager.AppService.Models.ProviderStackOsType? stackOsType = default(Azure.ResourceManager.AppService.Models.ProviderStackOsType?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.FunctionAppStack> GetFunctionAppStacksProvidersAsync(this Azure.ResourceManager.Resources.Tenant tenant, Azure.ResourceManager.AppService.Models.ProviderStackOsType? stackOsType = default(Azure.ResourceManager.AppService.Models.ProviderStackOsType?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.AppService.Models.GeoRegion> GetGeoRegions(this Azure.ResourceManager.Resources.Subscription subscription, Azure.ResourceManager.AppService.Models.AppServiceSkuName? sku = default(Azure.ResourceManager.AppService.Models.AppServiceSkuName?), bool? linuxWorkersEnabled = default(bool?), bool? xenonWorkersEnabled = default(bool?), bool? linuxDynamicWorkersEnabled = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.GeoRegion> GetGeoRegionsAsync(this Azure.ResourceManager.Resources.Subscription subscription, Azure.ResourceManager.AppService.Models.AppServiceSkuName? sku = default(Azure.ResourceManager.AppService.Models.AppServiceSkuName?), bool? linuxWorkersEnabled = default(bool?), bool? xenonWorkersEnabled = default(bool?), bool? linuxDynamicWorkersEnabled = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.AppService.HostingEnvironmentDetector GetHostingEnvironmentDetector(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.HostingEnvironmentMultiRolePool GetHostingEnvironmentMultiRolePool(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.HostingEnvironmentPrivateEndpointConnection GetHostingEnvironmentPrivateEndpointConnection(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.HostingEnvironmentRecommendation GetHostingEnvironmentRecommendation(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.HostingEnvironmentWorkerPool GetHostingEnvironmentWorkerPool(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.HybridConnectionLimits GetHybridConnectionLimits(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.KubeEnvironment GetKubeEnvironment(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.AppService.KubeEnvironment> GetKubeEnvironment(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup, string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.KubeEnvironment>> GetKubeEnvironmentAsync(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup, string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.AppService.KubeEnvironmentCollection GetKubeEnvironments(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.AppService.KubeEnvironment> GetKubeEnvironments(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.AppService.KubeEnvironment> GetKubeEnvironmentsAsync(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.AppService.LogsSiteConfig GetLogsSiteConfig(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.LogsSiteSlotConfig GetLogsSiteSlotConfig(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.MigrateMySqlStatus GetMigrateMySqlStatus(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.NetworkFeatures GetNetworkFeatures(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.AppService.Models.CsmOperationDescription> GetOperationsCertificateRegistrationProviders(this Azure.ResourceManager.Resources.Tenant tenant, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.CsmOperationDescription> GetOperationsCertificateRegistrationProvidersAsync(this Azure.ResourceManager.Resources.Tenant tenant, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.AppService.Models.CsmOperationDescription> GetOperationsDomainRegistrationProviders(this Azure.ResourceManager.Resources.Tenant tenant, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.CsmOperationDescription> GetOperationsDomainRegistrationProvidersAsync(this Azure.ResourceManager.Resources.Tenant tenant, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.AppService.Models.CsmOperationDescription> GetOperationsProviders(this Azure.ResourceManager.Resources.Tenant tenant, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.CsmOperationDescription> GetOperationsProvidersAsync(this Azure.ResourceManager.Resources.Tenant tenant, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.AppService.Models.PremierAddOnOffer> GetPremierAddOnOffers(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.PremierAddOnOffer> GetPremierAddOnOffersAsync(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.AppService.Models.AppServiceRecommendation> GetRecommendations(this Azure.ResourceManager.Resources.Subscription subscription, bool? featured = default(bool?), string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.AppServiceRecommendation> GetRecommendationsAsync(this Azure.ResourceManager.Resources.Subscription subscription, bool? featured = default(bool?), string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.AppService.Models.NameIdentifier> GetRecommendationsDomains(this Azure.ResourceManager.Resources.Subscription subscription, Azure.ResourceManager.AppService.Models.DomainRecommendationSearchParameters parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.NameIdentifier> GetRecommendationsDomainsAsync(this Azure.ResourceManager.Resources.Subscription subscription, Azure.ResourceManager.AppService.Models.DomainRecommendationSearchParameters parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.AppService.ScmSiteBasicPublishingCredentialsPolicy GetScmSiteBasicPublishingCredentialsPolicy(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.ScmSiteSlotBasicPublishingCredentialsPolicy GetScmSiteSlotBasicPublishingCredentialsPolicy(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.ServerfarmHybridConnectionNamespaceRelay GetServerfarmHybridConnectionNamespaceRelay(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.ServerfarmVirtualNetworkConnection GetServerfarmVirtualNetworkConnection(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.ServerfarmVirtualNetworkConnectionGateway GetServerfarmVirtualNetworkConnectionGateway(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteBackup GetSiteBackup(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteConfigAppsetting GetSiteConfigAppsetting(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteConfigConnectionString GetSiteConfigConnectionString(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteConfigSnapshot GetSiteConfigSnapshot(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteContinuousWebJob GetSiteContinuousWebJob(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteDeployment GetSiteDeployment(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteDetector GetSiteDetector(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteDiagnostic GetSiteDiagnostic(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteDiagnosticAnalysis GetSiteDiagnosticAnalysis(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteDiagnosticDetector GetSiteDiagnosticDetector(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteDomainOwnershipIdentifier GetSiteDomainOwnershipIdentifier(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteExtension GetSiteExtension(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteFunction GetSiteFunction(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteHostNameBinding GetSiteHostNameBinding(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteHybridConnection GetSiteHybridConnection(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteHybridConnectionNamespaceRelay GetSiteHybridConnectionNamespaceRelay(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.AppService.SiteDomainOwnershipIdentifier> GetSiteIdentifiersAssignedToHostName(this Azure.ResourceManager.Resources.Subscription subscription, Azure.ResourceManager.AppService.Models.NameIdentifier nameIdentifier, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteDomainOwnershipIdentifier> GetSiteIdentifiersAssignedToHostNameAsync(this Azure.ResourceManager.Resources.Subscription subscription, Azure.ResourceManager.AppService.Models.NameIdentifier nameIdentifier, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.AppService.SiteInstance GetSiteInstance(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteInstanceExtension GetSiteInstanceExtension(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteInstanceProcess GetSiteInstanceProcess(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteInstanceProcessModule GetSiteInstanceProcessModule(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteNetworkConfig GetSiteNetworkConfig(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SitePremierAddon GetSitePremierAddon(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SitePrivateAccess GetSitePrivateAccess(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SitePrivateEndpointConnection GetSitePrivateEndpointConnection(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteProcess GetSiteProcess(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteProcessModule GetSiteProcessModule(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SitePublicCertificate GetSitePublicCertificate(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteRecommendation GetSiteRecommendation(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteResourceHealthMetadata GetSiteResourceHealthMetadata(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteSiteextension GetSiteSiteextension(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteSlot GetSiteSlot(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteSlotBackup GetSiteSlotBackup(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteSlotConfigAppSetting GetSiteSlotConfigAppSetting(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteSlotConfigConnectionString GetSiteSlotConfigConnectionString(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteSlotConfigSnapshot GetSiteSlotConfigSnapshot(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteSlotContinuousWebJob GetSiteSlotContinuousWebJob(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteSlotDeployment GetSiteSlotDeployment(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteSlotDetector GetSiteSlotDetector(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteSlotDiagnostic GetSiteSlotDiagnostic(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteSlotDiagnosticAnalysis GetSiteSlotDiagnosticAnalysis(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteSlotDiagnosticDetector GetSiteSlotDiagnosticDetector(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteSlotDomainOwnershipIdentifier GetSiteSlotDomainOwnershipIdentifier(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteSlotExtension GetSiteSlotExtension(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteSlotFunction GetSiteSlotFunction(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteSlotHostNameBinding GetSiteSlotHostNameBinding(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteSlotHybridconnection GetSiteSlotHybridconnection(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteSlotHybridConnectionNamespaceRelay GetSiteSlotHybridConnectionNamespaceRelay(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteSlotInstance GetSiteSlotInstance(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteSlotInstanceExtension GetSiteSlotInstanceExtension(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteSlotInstanceProcess GetSiteSlotInstanceProcess(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteSlotInstanceProcessModule GetSiteSlotInstanceProcessModule(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteSlotNetworkConfig GetSiteSlotNetworkConfig(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteSlotPremierAddOn GetSiteSlotPremierAddOn(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteSlotPrivateAccess GetSiteSlotPrivateAccess(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteSlotPrivateEndpointConnection GetSiteSlotPrivateEndpointConnection(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteSlotProcess GetSiteSlotProcess(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteSlotProcessModule GetSiteSlotProcessModule(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteSlotPublicCertificate GetSiteSlotPublicCertificate(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteSlotResourceHealthMetadata GetSiteSlotResourceHealthMetadata(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteSlotSiteextension GetSiteSlotSiteextension(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteSlotSourcecontrol GetSiteSlotSourcecontrol(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteSlotTriggeredWebJob GetSiteSlotTriggeredWebJob(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteSlotTriggeredWebJobHistory GetSiteSlotTriggeredWebJobHistory(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteSlotVirtualNetworkConnection GetSiteSlotVirtualNetworkConnection(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteSlotVirtualNetworkConnectionGateway GetSiteSlotVirtualNetworkConnectionGateway(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteSlotWebJob GetSiteSlotWebJob(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteSourceControl GetSiteSourceControl(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteTriggeredwebJob GetSiteTriggeredwebJob(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteTriggeredWebJobHistory GetSiteTriggeredWebJobHistory(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteVirtualNetworkConnection GetSiteVirtualNetworkConnection(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteVirtualNetworkConnectionGateway GetSiteVirtualNetworkConnectionGateway(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SiteWebJob GetSiteWebJob(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.AppService.Models.SkuInfos> GetSkus(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.SkuInfos>> GetSkusAsync(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.AppService.SlotConfigNamesResource GetSlotConfigNamesResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.SourceControl GetSourceControl(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.AppService.SourceControl> GetSourceControl(this Azure.ResourceManager.Resources.Tenant tenant, string sourceControlType, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SourceControl>> GetSourceControlAsync(this Azure.ResourceManager.Resources.Tenant tenant, string sourceControlType, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.AppService.SourceControlCollection GetSourceControls(this Azure.ResourceManager.Resources.Tenant tenant) { throw null; }
        public static Azure.ResourceManager.AppService.StaticSiteARMResource GetStaticSiteARMResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.AppService.StaticSiteARMResource> GetStaticSiteARMResource(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup, string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.StaticSiteARMResource>> GetStaticSiteARMResourceAsync(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup, string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.AppService.StaticSiteARMResourceCollection GetStaticSiteARMResources(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.AppService.StaticSiteARMResource> GetStaticSiteARMResources(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.AppService.StaticSiteARMResource> GetStaticSiteARMResourcesAsync(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.AppService.StaticSiteBuildARMResource GetStaticSiteBuildARMResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.StaticSiteBuildUserProvidedFunctionApp GetStaticSiteBuildUserProvidedFunctionApp(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.StaticSiteCustomDomainOverviewARMResource GetStaticSiteCustomDomainOverviewARMResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.StaticSitePrivateEndpointConnection GetStaticSitePrivateEndpointConnection(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.StaticSiteUserProvidedFunctionApp GetStaticSiteUserProvidedFunctionApp(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.AppService.Models.DeploymentLocations> GetSubscriptionDeploymentLocations(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.DeploymentLocations>> GetSubscriptionDeploymentLocationsAsync(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response GetSubscriptionOperationWithAsyncResponseGlobal(this Azure.ResourceManager.Resources.Subscription subscription, string location, string operationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response> GetSubscriptionOperationWithAsyncResponseGlobalAsync(this Azure.ResourceManager.Resources.Subscription subscription, string location, string operationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.AppService.TopLevelDomain GetTopLevelDomain(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.AppService.TopLevelDomain> GetTopLevelDomain(this Azure.ResourceManager.Resources.Subscription subscription, string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.TopLevelDomain>> GetTopLevelDomainAsync(this Azure.ResourceManager.Resources.Subscription subscription, string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.AppService.TopLevelDomainCollection GetTopLevelDomains(this Azure.ResourceManager.Resources.Subscription subscription) { throw null; }
        public static Azure.ResourceManager.AppService.User GetUser(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.User GetUser(this Azure.ResourceManager.Resources.Tenant tenant) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.AppService.Models.WebAppStack> GetWebAppStacksForLocationProviders(this Azure.ResourceManager.Resources.Tenant tenant, string location, Azure.ResourceManager.AppService.Models.ProviderStackOsType? stackOsType = default(Azure.ResourceManager.AppService.Models.ProviderStackOsType?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.WebAppStack> GetWebAppStacksForLocationProvidersAsync(this Azure.ResourceManager.Resources.Tenant tenant, string location, Azure.ResourceManager.AppService.Models.ProviderStackOsType? stackOsType = default(Azure.ResourceManager.AppService.Models.ProviderStackOsType?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.AppService.Models.WebAppStack> GetWebAppStacksProviders(this Azure.ResourceManager.Resources.Tenant tenant, Azure.ResourceManager.AppService.Models.ProviderStackOsType? stackOsType = default(Azure.ResourceManager.AppService.Models.ProviderStackOsType?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.WebAppStack> GetWebAppStacksProvidersAsync(this Azure.ResourceManager.Resources.Tenant tenant, Azure.ResourceManager.AppService.Models.ProviderStackOsType? stackOsType = default(Azure.ResourceManager.AppService.Models.ProviderStackOsType?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.AppService.WebSite GetWebSite(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.AppService.WebSite> GetWebSite(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup, string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.WebSite>> GetWebSiteAsync(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup, string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.AppService.WebSiteConfig GetWebSiteConfig(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppService.WebSiteCollection GetWebSites(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.AppService.WebSite> GetWebSites(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.AppService.WebSite> GetWebSitesAsync(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.AppService.WebSiteSlotConfig GetWebSiteSlotConfig(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response Move(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup, Azure.ResourceManager.AppService.Models.CsmMoveResourceEnvelope moveResourceEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response> MoveAsync(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup, Azure.ResourceManager.AppService.Models.CsmMoveResourceEnvelope moveResourceEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.AppService.Models.StaticSitesWorkflowPreview> PreviewWorkflowStaticSite(this Azure.ResourceManager.Resources.Subscription subscription, string location, Azure.ResourceManager.AppService.Models.StaticSitesWorkflowPreviewRequest staticSitesWorkflowPreviewRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.StaticSitesWorkflowPreview>> PreviewWorkflowStaticSiteAsync(this Azure.ResourceManager.Resources.Subscription subscription, string location, Azure.ResourceManager.AppService.Models.StaticSitesWorkflowPreviewRequest staticSitesWorkflowPreviewRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response ResetAllFiltersRecommendation(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response> ResetAllFiltersRecommendationAsync(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.AppService.Models.ValidateResponse> Validate(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup, Azure.ResourceManager.AppService.Models.ValidateRequest validateRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.ValidateResponse>> ValidateAsync(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup, Azure.ResourceManager.AppService.Models.ValidateRequest validateRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response ValidateMove(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup, Azure.ResourceManager.AppService.Models.CsmMoveResourceEnvelope moveResourceEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response> ValidateMoveAsync(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup, Azure.ResourceManager.AppService.Models.CsmMoveResourceEnvelope moveResourceEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response ValidatePurchaseInformationAppServiceCertificateOrder(this Azure.ResourceManager.Resources.Subscription subscription, Azure.ResourceManager.AppService.AppServiceCertificateOrderData appServiceCertificateOrder, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response> ValidatePurchaseInformationAppServiceCertificateOrderAsync(this Azure.ResourceManager.Resources.Subscription subscription, Azure.ResourceManager.AppService.AppServiceCertificateOrderData appServiceCertificateOrder, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.AppService.Models.VnetValidationFailureDetails> VerifyHostingEnvironmentVnet(this Azure.ResourceManager.Resources.Subscription subscription, Azure.ResourceManager.AppService.Models.VnetParameters parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.VnetValidationFailureDetails>> VerifyHostingEnvironmentVnetAsync(this Azure.ResourceManager.Resources.Subscription subscription, Azure.ResourceManager.AppService.Models.VnetParameters parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class AppServicePlan : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected AppServicePlan() { }
        public virtual Azure.ResourceManager.AppService.AppServicePlanData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.AppService.AppServicePlan> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.AppServicePlan>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.AppServicePlan> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.AppServicePlan>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.Capability> GetCapabilities(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.Capability> GetCapabilitiesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.HybridConnectionLimits GetHybridConnectionLimits() { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.ServerfarmHybridConnectionNamespaceRelay> GetHybridConnections(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.ServerfarmHybridConnectionNamespaceRelay> GetHybridConnectionsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.ServerfarmHybridConnectionNamespaceRelay> GetServerfarmHybridConnectionNamespaceRelay(string namespaceName, string relayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.ServerfarmHybridConnectionNamespaceRelay>> GetServerfarmHybridConnectionNamespaceRelayAsync(string namespaceName, string relayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.ServerfarmHybridConnectionNamespaceRelayCollection GetServerfarmHybridConnectionNamespaceRelays() { throw null; }
        public virtual Azure.Response<System.BinaryData> GetServerFarmSkus(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.BinaryData>> GetServerFarmSkusAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.ServerfarmVirtualNetworkConnection> GetServerfarmVirtualNetworkConnection(string vnetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.ServerfarmVirtualNetworkConnection>> GetServerfarmVirtualNetworkConnectionAsync(string vnetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.ServerfarmVirtualNetworkConnectionCollection GetServerfarmVirtualNetworkConnections() { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.CsmUsageQuota> GetUsages(string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.CsmUsageQuota> GetUsagesAsync(string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.WebSite> GetWebApps(string skipToken = null, string filter = null, string top = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.WebSite> GetWebAppsAsync(string skipToken = null, string filter = null, string top = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response RebootWorker(string workerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> RebootWorkerAsync(string workerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.AppServicePlan> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.AppServicePlan>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response RestartWebApps(bool? softRestart = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> RestartWebAppsAsync(bool? softRestart = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.AppServicePlan> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.AppServicePlan>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.AppServicePlan> Update(Azure.ResourceManager.AppService.Models.PatchableAppServicePlanData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.AppServicePlan>> UpdateAsync(Azure.ResourceManager.AppService.Models.PatchableAppServicePlanData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class AppServicePlanCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.AppServicePlan>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.AppServicePlan>, System.Collections.IEnumerable
    {
        protected AppServicePlanCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.AppServicePlan> CreateOrUpdate(Azure.WaitUntil waitUntil, string name, Azure.ResourceManager.AppService.AppServicePlanData appServicePlan, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.AppServicePlan>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string name, Azure.ResourceManager.AppService.AppServicePlanData appServicePlan, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.AppServicePlan> Get(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.AppServicePlan> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.AppServicePlan> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.AppServicePlan>> GetAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.AppServicePlan> GetIfExists(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.AppServicePlan>> GetIfExistsAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.AppServicePlan> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.AppServicePlan>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.AppServicePlan> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.AppServicePlan>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class AppServicePlanData : Azure.ResourceManager.AppService.Models.AppServiceResource
    {
        public AppServicePlanData(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public bool? ElasticScaleEnabled { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.ExtendedLocation ExtendedLocation { get { throw null; } set { } }
        public System.DateTimeOffset? FreeOfferExpirationTime { get { throw null; } set { } }
        public string GeoRegion { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.HostingEnvironmentProfile HostingEnvironmentProfile { get { throw null; } set { } }
        public bool? HyperV { get { throw null; } set { } }
        public bool? IsSpot { get { throw null; } set { } }
        public bool? IsXenon { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.KubeEnvironmentProfile KubeEnvironmentProfile { get { throw null; } set { } }
        public int? MaximumElasticWorkerCount { get { throw null; } set { } }
        public int? MaximumNumberOfWorkers { get { throw null; } }
        public int? NumberOfSites { get { throw null; } }
        public bool? PerSiteScaling { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public bool? Reserved { get { throw null; } set { } }
        public string ResourceGroup { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.SkuDescription Sku { get { throw null; } set { } }
        public System.DateTimeOffset? SpotExpirationTime { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.StatusOptions? Status { get { throw null; } }
        public string Subscription { get { throw null; } }
        public int? TargetWorkerCount { get { throw null; } set { } }
        public int? TargetWorkerSizeId { get { throw null; } set { } }
        public string WorkerTierName { get { throw null; } set { } }
        public bool? ZoneRedundant { get { throw null; } set { } }
    }
    public partial class AseV3NetworkingConfiguration : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected AseV3NetworkingConfiguration() { }
        public virtual Azure.ResourceManager.AppService.AseV3NetworkingConfigurationData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.AseV3NetworkingConfiguration> CreateOrUpdate(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.AseV3NetworkingConfigurationData aseNetworkingConfiguration, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.AseV3NetworkingConfiguration>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.AseV3NetworkingConfigurationData aseNetworkingConfiguration, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.AseV3NetworkingConfiguration> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.AseV3NetworkingConfiguration>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class AseV3NetworkingConfigurationData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public AseV3NetworkingConfigurationData() { }
        public bool? AllowNewPrivateEndpointConnections { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<string> ExternalInboundIpAddresses { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> InternalInboundIpAddresses { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> LinuxOutboundIpAddresses { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> WindowsOutboundIpAddresses { get { throw null; } }
    }
    public partial class BackupItemData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public BackupItemData() { }
        public int? BackupId { get { throw null; } }
        public string BlobName { get { throw null; } }
        public string CorrelationId { get { throw null; } }
        public System.DateTimeOffset? Created { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppService.Models.DatabaseBackupSetting> Databases { get { throw null; } }
        public System.DateTimeOffset? FinishedTimeStamp { get { throw null; } }
        public System.DateTimeOffset? LastRestoreTimeStamp { get { throw null; } }
        public string Log { get { throw null; } }
        public string NamePropertiesName { get { throw null; } }
        public bool? Scheduled { get { throw null; } }
        public long? SizeInBytes { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.BackupItemStatus? Status { get { throw null; } }
        public string StorageAccountUrl { get { throw null; } }
        public long? WebsiteSizeInBytes { get { throw null; } }
    }
    public partial class BasicPublishingCredentialsPolicyFtp : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected BasicPublishingCredentialsPolicyFtp() { }
        public virtual Azure.ResourceManager.AppService.CsmPublishingCredentialsPoliciesEntityData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.BasicPublishingCredentialsPolicyFtp> CreateOrUpdate(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.CsmPublishingCredentialsPoliciesEntityData csmPublishingAccessPoliciesEntity, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.BasicPublishingCredentialsPolicyFtp>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.CsmPublishingCredentialsPoliciesEntityData csmPublishingAccessPoliciesEntity, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.BasicPublishingCredentialsPolicyFtp> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.BasicPublishingCredentialsPolicyFtp>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class Certificate : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected Certificate() { }
        public virtual Azure.ResourceManager.AppService.CertificateData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Certificate> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Certificate>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Certificate> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Certificate>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Certificate> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Certificate>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Certificate> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Certificate>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Certificate> Update(Azure.ResourceManager.AppService.Models.PatchableCertificateData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Certificate>> UpdateAsync(Azure.ResourceManager.AppService.Models.PatchableCertificateData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class CertificateCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.Certificate>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.Certificate>, System.Collections.IEnumerable
    {
        protected CertificateCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.Certificate> CreateOrUpdate(Azure.WaitUntil waitUntil, string name, Azure.ResourceManager.AppService.CertificateData certificateEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.Certificate>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string name, Azure.ResourceManager.AppService.CertificateData certificateEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Certificate> Get(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Certificate> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Certificate> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Certificate>> GetAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Certificate> GetIfExists(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Certificate>> GetIfExistsAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.Certificate> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.Certificate>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.Certificate> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.Certificate>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class CertificateData : Azure.ResourceManager.AppService.Models.AppServiceResource
    {
        public CertificateData(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public string CanonicalName { get { throw null; } set { } }
        public byte[] CerBlob { get { throw null; } }
        public string DomainValidationMethod { get { throw null; } set { } }
        public System.DateTimeOffset? ExpirationDate { get { throw null; } }
        public string FriendlyName { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.HostingEnvironmentProfile HostingEnvironmentProfile { get { throw null; } }
        public System.Collections.Generic.IList<string> HostNames { get { throw null; } }
        public System.DateTimeOffset? IssueDate { get { throw null; } }
        public string Issuer { get { throw null; } }
        public string KeyVaultId { get { throw null; } set { } }
        public string KeyVaultSecretName { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.KeyVaultSecretStatus? KeyVaultSecretStatus { get { throw null; } }
        public string Password { get { throw null; } set { } }
        public byte[] PfxBlob { get { throw null; } set { } }
        public string PublicKeyHash { get { throw null; } }
        public string SelfLink { get { throw null; } }
        public string ServerFarmId { get { throw null; } set { } }
        public string SiteName { get { throw null; } }
        public string SubjectName { get { throw null; } }
        public string Thumbprint { get { throw null; } }
        public bool? Valid { get { throw null; } }
    }
    public partial class CertificateOrderDetector : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected CertificateOrderDetector() { }
        public virtual Azure.ResourceManager.AppService.AppServiceDetectorData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string certificateOrderName, string detectorName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.CertificateOrderDetector> Get(System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.CertificateOrderDetector>> GetAsync(System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class CertificateOrderDetectorCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.CertificateOrderDetector>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.CertificateOrderDetector>, System.Collections.IEnumerable
    {
        protected CertificateOrderDetectorCollection() { }
        public virtual Azure.Response<bool> Exists(string detectorName, System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string detectorName, System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.CertificateOrderDetector> Get(string detectorName, System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.CertificateOrderDetector> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.CertificateOrderDetector> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.CertificateOrderDetector>> GetAsync(string detectorName, System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.CertificateOrderDetector> GetIfExists(string detectorName, System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.CertificateOrderDetector>> GetIfExistsAsync(string detectorName, System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.CertificateOrderDetector> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.CertificateOrderDetector>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.CertificateOrderDetector> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.CertificateOrderDetector>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ContinuousWebJobData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public ContinuousWebJobData() { }
        public string DetailedStatus { get { throw null; } set { } }
        public string Error { get { throw null; } set { } }
        public string ExtraInfoUrl { get { throw null; } set { } }
        public string LogUrl { get { throw null; } set { } }
        public string RunCommand { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, System.BinaryData> Settings { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.ContinuousWebJobStatus? Status { get { throw null; } set { } }
        public string Url { get { throw null; } set { } }
        public bool? UsingSdk { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.WebJobType? WebJobType { get { throw null; } set { } }
    }
    public partial class CsmPublishingCredentialsPoliciesEntityData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public CsmPublishingCredentialsPoliciesEntityData() { }
        public bool? Allow { get { throw null; } set { } }
    }
    public partial class DeletedSite : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected DeletedSite() { }
        public virtual Azure.ResourceManager.AppService.DeletedSiteData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string deletedSiteId) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.DeletedSite> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.DeletedSite>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.Snapshot> GetDeletedWebAppSnapshots(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.Snapshot> GetDeletedWebAppSnapshotsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class DeletedSiteCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.DeletedSite>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.DeletedSite>, System.Collections.IEnumerable
    {
        protected DeletedSiteCollection() { }
        public virtual Azure.Response<bool> Exists(string deletedSiteId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string deletedSiteId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.DeletedSite> Get(string deletedSiteId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.DeletedSite> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.DeletedSite> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.DeletedSite>> GetAsync(string deletedSiteId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.DeletedSite> GetIfExists(string deletedSiteId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.DeletedSite>> GetIfExistsAsync(string deletedSiteId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.DeletedSite> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.DeletedSite>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.DeletedSite> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.DeletedSite>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class DeletedSiteData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public DeletedSiteData() { }
        public int? DeletedSiteId { get { throw null; } }
        public string DeletedSiteName { get { throw null; } }
        public string DeletedTimestamp { get { throw null; } }
        public string GeoRegionName { get { throw null; } }
        public string KindPropertiesKind { get { throw null; } }
        public string ResourceGroup { get { throw null; } }
        public string Slot { get { throw null; } }
        public string Subscription { get { throw null; } }
    }
    public partial class DeploymentData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public DeploymentData() { }
        public bool? Active { get { throw null; } set { } }
        public string Author { get { throw null; } set { } }
        public string AuthorEmail { get { throw null; } set { } }
        public string Deployer { get { throw null; } set { } }
        public string Details { get { throw null; } set { } }
        public System.DateTimeOffset? EndTime { get { throw null; } set { } }
        public string Message { get { throw null; } set { } }
        public System.DateTimeOffset? StartTime { get { throw null; } set { } }
        public int? Status { get { throw null; } set { } }
    }
    public partial class DetectorDefinitionAutoGeneratedData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public DetectorDefinitionAutoGeneratedData() { }
        public string Description { get { throw null; } }
        public string DisplayName { get { throw null; } }
        public bool? IsEnabled { get { throw null; } }
        public double? Rank { get { throw null; } }
    }
    public partial class DiagnosticCategoryData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public DiagnosticCategoryData() { }
        public string Description { get { throw null; } }
    }
    public partial class DomainOwnershipIdentifier : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected DomainOwnershipIdentifier() { }
        public virtual Azure.ResourceManager.AppService.DomainOwnershipIdentifierData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string domainName, string name) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.DomainOwnershipIdentifier> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.DomainOwnershipIdentifier>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.DomainOwnershipIdentifier> Update(Azure.ResourceManager.AppService.DomainOwnershipIdentifierData domainOwnershipIdentifier, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.DomainOwnershipIdentifier>> UpdateAsync(Azure.ResourceManager.AppService.DomainOwnershipIdentifierData domainOwnershipIdentifier, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class DomainOwnershipIdentifierCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.DomainOwnershipIdentifier>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.DomainOwnershipIdentifier>, System.Collections.IEnumerable
    {
        protected DomainOwnershipIdentifierCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.DomainOwnershipIdentifier> CreateOrUpdate(Azure.WaitUntil waitUntil, string name, Azure.ResourceManager.AppService.DomainOwnershipIdentifierData domainOwnershipIdentifier, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.DomainOwnershipIdentifier>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string name, Azure.ResourceManager.AppService.DomainOwnershipIdentifierData domainOwnershipIdentifier, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.DomainOwnershipIdentifier> Get(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.DomainOwnershipIdentifier> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.DomainOwnershipIdentifier> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.DomainOwnershipIdentifier>> GetAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.DomainOwnershipIdentifier> GetIfExists(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.DomainOwnershipIdentifier>> GetIfExistsAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.DomainOwnershipIdentifier> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.DomainOwnershipIdentifier>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.DomainOwnershipIdentifier> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.DomainOwnershipIdentifier>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class DomainOwnershipIdentifierData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public DomainOwnershipIdentifierData() { }
        public string OwnershipId { get { throw null; } set { } }
    }
    public partial class FtpSiteSlotBasicPublishingCredentialsPolicy : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected FtpSiteSlotBasicPublishingCredentialsPolicy() { }
        public virtual Azure.ResourceManager.AppService.CsmPublishingCredentialsPoliciesEntityData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.FtpSiteSlotBasicPublishingCredentialsPolicy> CreateOrUpdate(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.CsmPublishingCredentialsPoliciesEntityData csmPublishingAccessPoliciesEntity, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.FtpSiteSlotBasicPublishingCredentialsPolicy>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.CsmPublishingCredentialsPoliciesEntityData csmPublishingAccessPoliciesEntity, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.FtpSiteSlotBasicPublishingCredentialsPolicy> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.FtpSiteSlotBasicPublishingCredentialsPolicy>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class FunctionEnvelopeData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public FunctionEnvelopeData() { }
        public System.BinaryData Config { get { throw null; } set { } }
        public string ConfigHref { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Files { get { throw null; } }
        public string FunctionAppId { get { throw null; } set { } }
        public string Href { get { throw null; } set { } }
        public string InvokeUrlTemplate { get { throw null; } set { } }
        public bool? IsDisabled { get { throw null; } set { } }
        public string Language { get { throw null; } set { } }
        public string ScriptHref { get { throw null; } set { } }
        public string ScriptRootPathHref { get { throw null; } set { } }
        public string SecretsFileHref { get { throw null; } set { } }
        public string TestData { get { throw null; } set { } }
        public string TestDataHref { get { throw null; } set { } }
    }
    public partial class HostingEnvironmentDetector : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected HostingEnvironmentDetector() { }
        public virtual Azure.ResourceManager.AppService.AppServiceDetectorData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string detectorName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.HostingEnvironmentDetector> Get(System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.HostingEnvironmentDetector>> GetAsync(System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class HostingEnvironmentDetectorCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.HostingEnvironmentDetector>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.HostingEnvironmentDetector>, System.Collections.IEnumerable
    {
        protected HostingEnvironmentDetectorCollection() { }
        public virtual Azure.Response<bool> Exists(string detectorName, System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string detectorName, System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.HostingEnvironmentDetector> Get(string detectorName, System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.HostingEnvironmentDetector> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.HostingEnvironmentDetector> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.HostingEnvironmentDetector>> GetAsync(string detectorName, System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.HostingEnvironmentDetector> GetIfExists(string detectorName, System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.HostingEnvironmentDetector>> GetIfExistsAsync(string detectorName, System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.HostingEnvironmentDetector> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.HostingEnvironmentDetector>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.HostingEnvironmentDetector> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.HostingEnvironmentDetector>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class HostingEnvironmentMultiRolePool : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected HostingEnvironmentMultiRolePool() { }
        public virtual Azure.ResourceManager.AppService.WorkerPoolResourceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.HostingEnvironmentMultiRolePool> CreateOrUpdate(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.WorkerPoolResourceData multiRolePoolEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.HostingEnvironmentMultiRolePool>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.WorkerPoolResourceData multiRolePoolEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.HostingEnvironmentMultiRolePool> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.HostingEnvironmentMultiRolePool>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.ResourceMetricDefinition> GetMultiRoleMetricDefinitions(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.ResourceMetricDefinition> GetMultiRoleMetricDefinitionsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.ResourceMetricDefinition> GetMultiRolePoolInstanceMetricDefinitions(string instance, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.ResourceMetricDefinition> GetMultiRolePoolInstanceMetricDefinitionsAsync(string instance, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.SkuInfo> GetMultiRolePoolSkus(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.SkuInfo> GetMultiRolePoolSkusAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.AppServiceUsage> GetMultiRoleUsages(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.AppServiceUsage> GetMultiRoleUsagesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.HostingEnvironmentMultiRolePool> Update(Azure.ResourceManager.AppService.WorkerPoolResourceData multiRolePoolEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.HostingEnvironmentMultiRolePool>> UpdateAsync(Azure.ResourceManager.AppService.WorkerPoolResourceData multiRolePoolEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class HostingEnvironmentPrivateEndpointConnection : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected HostingEnvironmentPrivateEndpointConnection() { }
        public virtual Azure.ResourceManager.AppService.RemotePrivateEndpointConnectionARMResourceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string privateEndpointConnectionName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<System.BinaryData> Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<System.BinaryData>> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.HostingEnvironmentPrivateEndpointConnection> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.HostingEnvironmentPrivateEndpointConnection>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class HostingEnvironmentPrivateEndpointConnectionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.HostingEnvironmentPrivateEndpointConnection>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.HostingEnvironmentPrivateEndpointConnection>, System.Collections.IEnumerable
    {
        protected HostingEnvironmentPrivateEndpointConnectionCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.HostingEnvironmentPrivateEndpointConnection> CreateOrUpdate(Azure.WaitUntil waitUntil, string privateEndpointConnectionName, Azure.ResourceManager.AppService.Models.PrivateLinkConnectionApprovalRequestResource privateEndpointWrapper, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.HostingEnvironmentPrivateEndpointConnection>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string privateEndpointConnectionName, Azure.ResourceManager.AppService.Models.PrivateLinkConnectionApprovalRequestResource privateEndpointWrapper, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.HostingEnvironmentPrivateEndpointConnection> Get(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.HostingEnvironmentPrivateEndpointConnection> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.HostingEnvironmentPrivateEndpointConnection> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.HostingEnvironmentPrivateEndpointConnection>> GetAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.HostingEnvironmentPrivateEndpointConnection> GetIfExists(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.HostingEnvironmentPrivateEndpointConnection>> GetIfExistsAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.HostingEnvironmentPrivateEndpointConnection> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.HostingEnvironmentPrivateEndpointConnection>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.HostingEnvironmentPrivateEndpointConnection> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.HostingEnvironmentPrivateEndpointConnection>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class HostingEnvironmentRecommendation : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected HostingEnvironmentRecommendation() { }
        public virtual Azure.ResourceManager.AppService.RecommendationRuleData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string hostingEnvironmentName, string name) { throw null; }
        public virtual Azure.Response DisableRecommendationForHostingEnvironment(string environmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DisableRecommendationForHostingEnvironmentAsync(string environmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.HostingEnvironmentRecommendation> Get(bool? updateSeen = default(bool?), string recommendationId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.HostingEnvironmentRecommendation>> GetAsync(bool? updateSeen = default(bool?), string recommendationId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class HostingEnvironmentRecommendationCollection : Azure.ResourceManager.ArmCollection
    {
        protected HostingEnvironmentRecommendationCollection() { }
        public virtual Azure.Response<bool> Exists(string name, bool? updateSeen = default(bool?), string recommendationId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string name, bool? updateSeen = default(bool?), string recommendationId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.HostingEnvironmentRecommendation> Get(string name, bool? updateSeen = default(bool?), string recommendationId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.HostingEnvironmentRecommendation>> GetAsync(string name, bool? updateSeen = default(bool?), string recommendationId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.HostingEnvironmentRecommendation> GetIfExists(string name, bool? updateSeen = default(bool?), string recommendationId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.HostingEnvironmentRecommendation>> GetIfExistsAsync(string name, bool? updateSeen = default(bool?), string recommendationId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class HostingEnvironmentWorkerPool : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected HostingEnvironmentWorkerPool() { }
        public virtual Azure.ResourceManager.AppService.WorkerPoolResourceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string workerPoolName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.HostingEnvironmentWorkerPool> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.HostingEnvironmentWorkerPool>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.ResourceMetricDefinition> GetWebWorkerMetricDefinitions(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.ResourceMetricDefinition> GetWebWorkerMetricDefinitionsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.AppServiceUsage> GetWebWorkerUsages(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.AppServiceUsage> GetWebWorkerUsagesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.ResourceMetricDefinition> GetWorkerPoolInstanceMetricDefinitions(string instance, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.ResourceMetricDefinition> GetWorkerPoolInstanceMetricDefinitionsAsync(string instance, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.SkuInfo> GetWorkerPoolSkus(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.SkuInfo> GetWorkerPoolSkusAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.HostingEnvironmentWorkerPool> Update(Azure.ResourceManager.AppService.WorkerPoolResourceData workerPoolEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.HostingEnvironmentWorkerPool>> UpdateAsync(Azure.ResourceManager.AppService.WorkerPoolResourceData workerPoolEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class HostingEnvironmentWorkerPoolCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.HostingEnvironmentWorkerPool>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.HostingEnvironmentWorkerPool>, System.Collections.IEnumerable
    {
        protected HostingEnvironmentWorkerPoolCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.HostingEnvironmentWorkerPool> CreateOrUpdate(Azure.WaitUntil waitUntil, string workerPoolName, Azure.ResourceManager.AppService.WorkerPoolResourceData workerPoolEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.HostingEnvironmentWorkerPool>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string workerPoolName, Azure.ResourceManager.AppService.WorkerPoolResourceData workerPoolEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string workerPoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string workerPoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.HostingEnvironmentWorkerPool> Get(string workerPoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.HostingEnvironmentWorkerPool> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.HostingEnvironmentWorkerPool> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.HostingEnvironmentWorkerPool>> GetAsync(string workerPoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.HostingEnvironmentWorkerPool> GetIfExists(string workerPoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.HostingEnvironmentWorkerPool>> GetIfExistsAsync(string workerPoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.HostingEnvironmentWorkerPool> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.HostingEnvironmentWorkerPool>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.HostingEnvironmentWorkerPool> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.HostingEnvironmentWorkerPool>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class HostNameBindingData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public HostNameBindingData() { }
        public string AzureResourceName { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.AzureResourceType? AzureResourceType { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.CustomHostNameDnsRecordType? CustomHostNameDnsRecordType { get { throw null; } set { } }
        public string DomainId { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.HostNameType? HostNameType { get { throw null; } set { } }
        public string SiteName { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.SslState? SslState { get { throw null; } set { } }
        public string Thumbprint { get { throw null; } set { } }
        public string VirtualIP { get { throw null; } }
    }
    public partial class HybridConnectionData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public HybridConnectionData() { }
        public string Hostname { get { throw null; } set { } }
        public int? Port { get { throw null; } set { } }
        public System.Uri RelayArmUri { get { throw null; } set { } }
        public string RelayName { get { throw null; } set { } }
        public string SendKeyName { get { throw null; } set { } }
        public string SendKeyValue { get { throw null; } set { } }
        public string ServiceBusNamespace { get { throw null; } set { } }
        public string ServiceBusSuffix { get { throw null; } set { } }
    }
    public partial class HybridConnectionLimits : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected HybridConnectionLimits() { }
        public virtual Azure.ResourceManager.AppService.HybridConnectionLimitsData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.HybridConnectionLimits> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.HybridConnectionLimits>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class HybridConnectionLimitsData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public HybridConnectionLimitsData() { }
        public int? Current { get { throw null; } }
        public int? Maximum { get { throw null; } }
    }
    public partial class IdentifierData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public IdentifierData() { }
        public string Value { get { throw null; } set { } }
    }
    public partial class KubeEnvironment : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected KubeEnvironment() { }
        public virtual Azure.ResourceManager.AppService.KubeEnvironmentData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.AppService.KubeEnvironment> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.KubeEnvironment>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.KubeEnvironment> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.KubeEnvironment>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.KubeEnvironment> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.KubeEnvironment>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.KubeEnvironment> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.KubeEnvironment>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.KubeEnvironment> Update(Azure.ResourceManager.AppService.Models.PatchableKubeEnvironmentData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.KubeEnvironment>> UpdateAsync(Azure.ResourceManager.AppService.Models.PatchableKubeEnvironmentData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class KubeEnvironmentCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.KubeEnvironment>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.KubeEnvironment>, System.Collections.IEnumerable
    {
        protected KubeEnvironmentCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.KubeEnvironment> CreateOrUpdate(Azure.WaitUntil waitUntil, string name, Azure.ResourceManager.AppService.KubeEnvironmentData kubeEnvironmentEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.KubeEnvironment>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string name, Azure.ResourceManager.AppService.KubeEnvironmentData kubeEnvironmentEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.KubeEnvironment> Get(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.KubeEnvironment> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.KubeEnvironment> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.KubeEnvironment>> GetAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.KubeEnvironment> GetIfExists(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.KubeEnvironment>> GetIfExistsAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.KubeEnvironment> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.KubeEnvironment>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.KubeEnvironment> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.KubeEnvironment>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class KubeEnvironmentData : Azure.ResourceManager.AppService.Models.AppServiceResource
    {
        public KubeEnvironmentData(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public string AksResourceID { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.AppLogsConfiguration AppLogsConfiguration { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.ArcConfiguration ArcConfiguration { get { throw null; } set { } }
        public string DefaultDomain { get { throw null; } }
        public string DeploymentErrors { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.ExtendedLocation ExtendedLocation { get { throw null; } set { } }
        public bool? InternalLoadBalancerEnabled { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.KubeEnvironmentProvisioningState? ProvisioningState { get { throw null; } }
        public string StaticIp { get { throw null; } set { } }
    }
    public partial class LogsSiteConfig : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected LogsSiteConfig() { }
        public virtual Azure.ResourceManager.AppService.SiteLogsConfigData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.LogsSiteConfig> CreateOrUpdate(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.SiteLogsConfigData siteLogsConfig, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.LogsSiteConfig>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.SiteLogsConfigData siteLogsConfig, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.LogsSiteConfig> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.LogsSiteConfig>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class LogsSiteSlotConfig : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected LogsSiteSlotConfig() { }
        public virtual Azure.ResourceManager.AppService.SiteLogsConfigData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.LogsSiteSlotConfig> CreateOrUpdate(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.SiteLogsConfigData siteLogsConfig, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.LogsSiteSlotConfig>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.SiteLogsConfigData siteLogsConfig, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.LogsSiteSlotConfig> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.LogsSiteSlotConfig>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class MigrateMySqlStatus : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected MigrateMySqlStatus() { }
        public virtual Azure.ResourceManager.AppService.MigrateMySqlStatusData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.MigrateMySqlStatus> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.MigrateMySqlStatus>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class MigrateMySqlStatusData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public MigrateMySqlStatusData() { }
        public bool? LocalMySqlEnabled { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.OperationStatus? MigrationOperationStatus { get { throw null; } }
        public string OperationId { get { throw null; } }
    }
    public partial class MSDeployStatusData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public MSDeployStatusData() { }
        public bool? Complete { get { throw null; } }
        public string Deployer { get { throw null; } }
        public System.DateTimeOffset? EndTime { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.MSDeployProvisioningState? ProvisioningState { get { throw null; } }
        public System.DateTimeOffset? StartTime { get { throw null; } }
    }
    public partial class NetworkFeatures : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected NetworkFeatures() { }
        public virtual Azure.ResourceManager.AppService.NetworkFeaturesData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot, string view) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.NetworkFeatures> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.NetworkFeatures>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class NetworkFeaturesCollection : Azure.ResourceManager.ArmCollection
    {
        protected NetworkFeaturesCollection() { }
        public virtual Azure.Response<bool> Exists(string view, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string view, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.NetworkFeatures> Get(string view, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.NetworkFeatures>> GetAsync(string view, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.NetworkFeatures> GetIfExists(string view, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.NetworkFeatures>> GetIfExistsAsync(string view, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class NetworkFeaturesData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public NetworkFeaturesData() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppService.RelayServiceConnectionEntityData> HybridConnections { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppService.HybridConnectionData> HybridConnectionsV2 { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.VnetInfo VirtualNetworkConnection { get { throw null; } }
        public string VirtualNetworkName { get { throw null; } }
    }
    public partial class PremierAddOnData : Azure.ResourceManager.AppService.Models.AppServiceResource
    {
        public PremierAddOnData(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public string MarketplaceOffer { get { throw null; } set { } }
        public string MarketplacePublisher { get { throw null; } set { } }
        public string Product { get { throw null; } set { } }
        public string Sku { get { throw null; } set { } }
        public string Vendor { get { throw null; } set { } }
    }
    public partial class PrivateAccessData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public PrivateAccessData() { }
        public bool? Enabled { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.PrivateAccessVirtualNetwork> VirtualNetworks { get { throw null; } }
    }
    public partial class ProcessInfoData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public ProcessInfoData() { }
        public System.Collections.Generic.IList<string> Children { get { throw null; } }
        public string CommandLine { get { throw null; } set { } }
        public string DeploymentName { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> EnvironmentVariables { get { throw null; } }
        public string FileName { get { throw null; } set { } }
        public int? HandleCount { get { throw null; } set { } }
        public string Href { get { throw null; } set { } }
        public int? Identifier { get { throw null; } }
        public double? IisProfileTimeoutInSeconds { get { throw null; } set { } }
        public bool? IsIisProfileRunning { get { throw null; } set { } }
        public bool? IsProfileRunning { get { throw null; } set { } }
        public bool? IsScmSite { get { throw null; } set { } }
        public bool? IsWebjob { get { throw null; } set { } }
        public string Minidump { get { throw null; } set { } }
        public int? ModuleCount { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.ProcessModuleInfoData> Modules { get { throw null; } }
        public long? NonPagedSystemMemory { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> OpenFileHandles { get { throw null; } }
        public long? PagedMemory { get { throw null; } set { } }
        public long? PagedSystemMemory { get { throw null; } set { } }
        public string Parent { get { throw null; } set { } }
        public long? PeakPagedMemory { get { throw null; } set { } }
        public long? PeakVirtualMemory { get { throw null; } set { } }
        public long? PeakWorkingSet { get { throw null; } set { } }
        public long? PrivateMemory { get { throw null; } set { } }
        public string PrivilegedCpuTime { get { throw null; } set { } }
        public System.DateTimeOffset? StartTime { get { throw null; } set { } }
        public int? ThreadCount { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.ProcessThreadInfo> Threads { get { throw null; } }
        public System.DateTimeOffset? TimeStamp { get { throw null; } set { } }
        public string TotalCpuTime { get { throw null; } set { } }
        public string UserCpuTime { get { throw null; } set { } }
        public string UserName { get { throw null; } set { } }
        public long? VirtualMemory { get { throw null; } set { } }
        public long? WorkingSet { get { throw null; } set { } }
    }
    public partial class ProcessModuleInfoData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public ProcessModuleInfoData() { }
        public string BaseAddress { get { throw null; } set { } }
        public string FileDescription { get { throw null; } set { } }
        public string FileName { get { throw null; } set { } }
        public string FilePath { get { throw null; } set { } }
        public string FileVersion { get { throw null; } set { } }
        public string Href { get { throw null; } set { } }
        public bool? IsDebug { get { throw null; } set { } }
        public string Language { get { throw null; } set { } }
        public int? ModuleMemorySize { get { throw null; } set { } }
        public string Product { get { throw null; } set { } }
        public string ProductVersion { get { throw null; } set { } }
    }
    public partial class PublicCertificateData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public PublicCertificateData() { }
        public byte[] Blob { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.PublicCertificateLocation? PublicCertificateLocation { get { throw null; } set { } }
        public string Thumbprint { get { throw null; } }
    }
    public partial class RecommendationRuleData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public RecommendationRuleData() { }
        public string ActionName { get { throw null; } set { } }
        public string BladeName { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<string> CategoryTags { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.Channels? Channels { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public string ExtensionName { get { throw null; } set { } }
        public string ForwardLink { get { throw null; } set { } }
        public bool? IsDynamic { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.NotificationLevel? Level { get { throw null; } set { } }
        public string Message { get { throw null; } set { } }
        public System.Guid? RecommendationId { get { throw null; } set { } }
        public string RecommendationName { get { throw null; } set { } }
    }
    public partial class RelayServiceConnectionEntityData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public RelayServiceConnectionEntityData() { }
        public System.Uri BiztalkUri { get { throw null; } set { } }
        public string EntityConnectionString { get { throw null; } set { } }
        public string EntityName { get { throw null; } set { } }
        public string Hostname { get { throw null; } set { } }
        public int? Port { get { throw null; } set { } }
        public string ResourceConnectionString { get { throw null; } set { } }
    }
    public partial class RemotePrivateEndpointConnectionARMResourceData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public RemotePrivateEndpointConnectionARMResourceData() { }
        public System.Collections.Generic.IList<string> IpAddresses { get { throw null; } }
        public Azure.Core.ResourceIdentifier PrivateEndpointId { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.PrivateLinkConnectionState PrivateLinkServiceConnectionState { get { throw null; } set { } }
        public string ProvisioningState { get { throw null; } }
    }
    public partial class ResourceHealthMetadataData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public ResourceHealthMetadataData() { }
        public string Category { get { throw null; } set { } }
        public bool? SignalAvailability { get { throw null; } set { } }
    }
    public partial class ScmSiteBasicPublishingCredentialsPolicy : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ScmSiteBasicPublishingCredentialsPolicy() { }
        public virtual Azure.ResourceManager.AppService.CsmPublishingCredentialsPoliciesEntityData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.ScmSiteBasicPublishingCredentialsPolicy> CreateOrUpdate(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.CsmPublishingCredentialsPoliciesEntityData csmPublishingAccessPoliciesEntity, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.ScmSiteBasicPublishingCredentialsPolicy>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.CsmPublishingCredentialsPoliciesEntityData csmPublishingAccessPoliciesEntity, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.ScmSiteBasicPublishingCredentialsPolicy> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.ScmSiteBasicPublishingCredentialsPolicy>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ScmSiteSlotBasicPublishingCredentialsPolicy : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ScmSiteSlotBasicPublishingCredentialsPolicy() { }
        public virtual Azure.ResourceManager.AppService.CsmPublishingCredentialsPoliciesEntityData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.ScmSiteSlotBasicPublishingCredentialsPolicy> CreateOrUpdate(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.CsmPublishingCredentialsPoliciesEntityData csmPublishingAccessPoliciesEntity, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.ScmSiteSlotBasicPublishingCredentialsPolicy>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.CsmPublishingCredentialsPoliciesEntityData csmPublishingAccessPoliciesEntity, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.ScmSiteSlotBasicPublishingCredentialsPolicy> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.ScmSiteSlotBasicPublishingCredentialsPolicy>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ServerfarmHybridConnectionNamespaceRelay : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ServerfarmHybridConnectionNamespaceRelay() { }
        public virtual Azure.ResourceManager.AppService.HybridConnectionData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string namespaceName, string relayName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.ServerfarmHybridConnectionNamespaceRelay> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.ServerfarmHybridConnectionNamespaceRelay>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.HybridConnectionKey> GetHybridConnectionKeys(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.HybridConnectionKey>> GetHybridConnectionKeysAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<string> GetWebAppsByHybridConnection(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<string> GetWebAppsByHybridConnectionAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ServerfarmHybridConnectionNamespaceRelayCollection : Azure.ResourceManager.ArmCollection
    {
        protected ServerfarmHybridConnectionNamespaceRelayCollection() { }
        public virtual Azure.Response<bool> Exists(string namespaceName, string relayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string namespaceName, string relayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.ServerfarmHybridConnectionNamespaceRelay> Get(string namespaceName, string relayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.ServerfarmHybridConnectionNamespaceRelay>> GetAsync(string namespaceName, string relayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.ServerfarmHybridConnectionNamespaceRelay> GetIfExists(string namespaceName, string relayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.ServerfarmHybridConnectionNamespaceRelay>> GetIfExistsAsync(string namespaceName, string relayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ServerfarmVirtualNetworkConnection : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ServerfarmVirtualNetworkConnection() { }
        public virtual Azure.ResourceManager.AppService.VnetInfoResourceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.VnetRoute> CreateOrUpdateVnetRoute(string routeName, Azure.ResourceManager.AppService.Models.VnetRoute route, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.VnetRoute>> CreateOrUpdateVnetRouteAsync(string routeName, Azure.ResourceManager.AppService.Models.VnetRoute route, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string vnetName) { throw null; }
        public virtual Azure.Response DeleteVnetRoute(string routeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteVnetRouteAsync(string routeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.ServerfarmVirtualNetworkConnection> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.ServerfarmVirtualNetworkConnection>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.VnetRoute> GetRoutesForVnet(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.VnetRoute> GetRoutesForVnetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.ServerfarmVirtualNetworkConnectionGateway> GetServerfarmVirtualNetworkConnectionGateway(string gatewayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.ServerfarmVirtualNetworkConnectionGateway>> GetServerfarmVirtualNetworkConnectionGatewayAsync(string gatewayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.ServerfarmVirtualNetworkConnectionGatewayCollection GetServerfarmVirtualNetworkConnectionGateways() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.VnetRoute> UpdateVnetRoute(string routeName, Azure.ResourceManager.AppService.Models.VnetRoute route, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.VnetRoute>> UpdateVnetRouteAsync(string routeName, Azure.ResourceManager.AppService.Models.VnetRoute route, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ServerfarmVirtualNetworkConnectionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.ServerfarmVirtualNetworkConnection>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.ServerfarmVirtualNetworkConnection>, System.Collections.IEnumerable
    {
        protected ServerfarmVirtualNetworkConnectionCollection() { }
        public virtual Azure.Response<bool> Exists(string vnetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string vnetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.ServerfarmVirtualNetworkConnection> Get(string vnetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.ServerfarmVirtualNetworkConnection> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.ServerfarmVirtualNetworkConnection> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.ServerfarmVirtualNetworkConnection>> GetAsync(string vnetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.ServerfarmVirtualNetworkConnection> GetIfExists(string vnetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.ServerfarmVirtualNetworkConnection>> GetIfExistsAsync(string vnetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.ServerfarmVirtualNetworkConnection> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.ServerfarmVirtualNetworkConnection>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.ServerfarmVirtualNetworkConnection> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.ServerfarmVirtualNetworkConnection>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ServerfarmVirtualNetworkConnectionGateway : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ServerfarmVirtualNetworkConnectionGateway() { }
        public virtual Azure.ResourceManager.AppService.VnetGatewayData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string vnetName, string gatewayName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.ServerfarmVirtualNetworkConnectionGateway> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.ServerfarmVirtualNetworkConnectionGateway>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ServerfarmVirtualNetworkConnectionGatewayCollection : Azure.ResourceManager.ArmCollection
    {
        protected ServerfarmVirtualNetworkConnectionGatewayCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.ServerfarmVirtualNetworkConnectionGateway> CreateOrUpdate(Azure.WaitUntil waitUntil, string gatewayName, Azure.ResourceManager.AppService.VnetGatewayData connectionEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.ServerfarmVirtualNetworkConnectionGateway>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string gatewayName, Azure.ResourceManager.AppService.VnetGatewayData connectionEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string gatewayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string gatewayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.ServerfarmVirtualNetworkConnectionGateway> Get(string gatewayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.ServerfarmVirtualNetworkConnectionGateway>> GetAsync(string gatewayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.ServerfarmVirtualNetworkConnectionGateway> GetIfExists(string gatewayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.ServerfarmVirtualNetworkConnectionGateway>> GetIfExistsAsync(string gatewayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteBackup : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteBackup() { }
        public virtual Azure.ResourceManager.AppService.BackupItemData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string backupId) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteBackup> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteBackup>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteBackup> GetBackupStatusSecrets(Azure.ResourceManager.AppService.Models.BackupRequest request, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteBackup>> GetBackupStatusSecretsAsync(Azure.ResourceManager.AppService.Models.BackupRequest request, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Restore(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.Models.RestoreRequest request, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> RestoreAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.Models.RestoreRequest request, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteBackupCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteBackup>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteBackup>, System.Collections.IEnumerable
    {
        protected SiteBackupCollection() { }
        public virtual Azure.Response<bool> Exists(string backupId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string backupId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteBackup> Get(string backupId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteBackup> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteBackup> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteBackup>> GetAsync(string backupId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteBackup> GetIfExists(string backupId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteBackup>> GetIfExistsAsync(string backupId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SiteBackup> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteBackup>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SiteBackup> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteBackup>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteConfigAppsetting : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteConfigAppsetting() { }
        public virtual Azure.ResourceManager.AppService.ApiKeyVaultReferenceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string appSettingKey) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteConfigAppsetting> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteConfigAppsetting>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteConfigAppsettingCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteConfigAppsetting>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteConfigAppsetting>, System.Collections.IEnumerable
    {
        protected SiteConfigAppsettingCollection() { }
        public virtual Azure.Response<bool> Exists(string appSettingKey, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string appSettingKey, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteConfigAppsetting> Get(string appSettingKey, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteConfigAppsetting> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteConfigAppsetting> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteConfigAppsetting>> GetAsync(string appSettingKey, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteConfigAppsetting> GetIfExists(string appSettingKey, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteConfigAppsetting>> GetIfExistsAsync(string appSettingKey, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SiteConfigAppsetting> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteConfigAppsetting>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SiteConfigAppsetting> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteConfigAppsetting>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteConfigConnectionString : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteConfigConnectionString() { }
        public virtual Azure.ResourceManager.AppService.ApiKeyVaultReferenceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string connectionStringKey) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteConfigConnectionString> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteConfigConnectionString>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteConfigConnectionStringCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteConfigConnectionString>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteConfigConnectionString>, System.Collections.IEnumerable
    {
        protected SiteConfigConnectionStringCollection() { }
        public virtual Azure.Response<bool> Exists(string connectionStringKey, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string connectionStringKey, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteConfigConnectionString> Get(string connectionStringKey, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteConfigConnectionString> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteConfigConnectionString> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteConfigConnectionString>> GetAsync(string connectionStringKey, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteConfigConnectionString> GetIfExists(string connectionStringKey, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteConfigConnectionString>> GetIfExistsAsync(string connectionStringKey, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SiteConfigConnectionString> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteConfigConnectionString>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SiteConfigConnectionString> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteConfigConnectionString>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteConfigData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public SiteConfigData() { }
        public bool? AcrUseManagedIdentityCreds { get { throw null; } set { } }
        public string AcrUserManagedIdentityID { get { throw null; } set { } }
        public bool? AlwaysOn { get { throw null; } set { } }
        public string ApiDefinitionUrl { get { throw null; } set { } }
        public string ApiManagementConfigId { get { throw null; } set { } }
        public string AppCommandLine { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.NameValuePair> AppSettings { get { throw null; } set { } }
        public bool? AutoHealEnabled { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.AutoHealRules AutoHealRules { get { throw null; } set { } }
        public string AutoSwapSlotName { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, Azure.ResourceManager.AppService.Models.AzureStorageInfoValue> AzureStorageAccounts { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.ConnStringInfo> ConnectionStrings { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.CorsSettings Cors { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> DefaultDocuments { get { throw null; } set { } }
        public bool? DetailedErrorLoggingEnabled { get { throw null; } set { } }
        public string DocumentRoot { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.RampUpRule> ExperimentsRampUpRules { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.FtpsState? FtpsState { get { throw null; } set { } }
        public int? FunctionAppScaleLimit { get { throw null; } set { } }
        public bool? FunctionsRuntimeScaleMonitoringEnabled { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.HandlerMapping> HandlerMappings { get { throw null; } set { } }
        public string HealthCheckPath { get { throw null; } set { } }
        public bool? Http20Enabled { get { throw null; } set { } }
        public bool? HttpLoggingEnabled { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.IpSecurityRestriction> IpSecurityRestrictions { get { throw null; } set { } }
        public string JavaContainer { get { throw null; } set { } }
        public string JavaContainerVersion { get { throw null; } set { } }
        public string JavaVersion { get { throw null; } set { } }
        public string KeyVaultReferenceIdentity { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.SiteLimits Limits { get { throw null; } set { } }
        public string LinuxFxVersion { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.SiteLoadBalancing? LoadBalancing { get { throw null; } set { } }
        public bool? LocalMySqlEnabled { get { throw null; } set { } }
        public int? LogsDirectorySizeLimit { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.SiteMachineKey MachineKey { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.ManagedPipelineMode? ManagedPipelineMode { get { throw null; } set { } }
        public int? ManagedServiceIdentityId { get { throw null; } set { } }
        public int? MinimumElasticInstanceCount { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.SupportedTlsVersions? MinTlsVersion { get { throw null; } set { } }
        public string NetFrameworkVersion { get { throw null; } set { } }
        public string NodeVersion { get { throw null; } set { } }
        public int? NumberOfWorkers { get { throw null; } set { } }
        public string PhpVersion { get { throw null; } set { } }
        public string PowerShellVersion { get { throw null; } set { } }
        public int? PreWarmedInstanceCount { get { throw null; } set { } }
        public string PublicNetworkAccess { get { throw null; } set { } }
        public string PublishingUsername { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.PushSettings Push { get { throw null; } set { } }
        public string PythonVersion { get { throw null; } set { } }
        public bool? RemoteDebuggingEnabled { get { throw null; } set { } }
        public string RemoteDebuggingVersion { get { throw null; } set { } }
        public bool? RequestTracingEnabled { get { throw null; } set { } }
        public System.DateTimeOffset? RequestTracingExpirationTime { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.IpSecurityRestriction> ScmIpSecurityRestrictions { get { throw null; } set { } }
        public bool? ScmIpSecurityRestrictionsUseMain { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.SupportedTlsVersions? ScmMinTlsVersion { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.ScmType? ScmType { get { throw null; } set { } }
        public string TracingOptions { get { throw null; } set { } }
        public bool? Use32BitWorkerProcess { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.VirtualApplication> VirtualApplications { get { throw null; } set { } }
        public string VnetName { get { throw null; } set { } }
        public int? VnetPrivatePortsCount { get { throw null; } set { } }
        public bool? VnetRouteAllEnabled { get { throw null; } set { } }
        public string WebsiteTimeZone { get { throw null; } set { } }
        public bool? WebSocketsEnabled { get { throw null; } set { } }
        public string WindowsFxVersion { get { throw null; } set { } }
        public int? XManagedServiceIdentityId { get { throw null; } set { } }
    }
    public partial class SiteConfigSnapshot : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteConfigSnapshot() { }
        public virtual Azure.ResourceManager.AppService.SiteConfigData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string snapshotId) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteConfigSnapshot> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteConfigSnapshot>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response RecoverSiteConfigurationSnapshot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> RecoverSiteConfigurationSnapshotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteConfigSnapshotCollection : Azure.ResourceManager.ArmCollection
    {
        protected SiteConfigSnapshotCollection() { }
        public virtual Azure.Response<bool> Exists(string snapshotId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string snapshotId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteConfigSnapshot> Get(string snapshotId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteConfigSnapshot>> GetAsync(string snapshotId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteConfigSnapshot> GetIfExists(string snapshotId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteConfigSnapshot>> GetIfExistsAsync(string snapshotId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteContinuousWebJob : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteContinuousWebJob() { }
        public virtual Azure.ResourceManager.AppService.ContinuousWebJobData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string webJobName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteContinuousWebJob> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteContinuousWebJob>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response StartContinuousWebJob(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> StartContinuousWebJobAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response StopContinuousWebJob(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> StopContinuousWebJobAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteContinuousWebJobCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteContinuousWebJob>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteContinuousWebJob>, System.Collections.IEnumerable
    {
        protected SiteContinuousWebJobCollection() { }
        public virtual Azure.Response<bool> Exists(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteContinuousWebJob> Get(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteContinuousWebJob> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteContinuousWebJob> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteContinuousWebJob>> GetAsync(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteContinuousWebJob> GetIfExists(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteContinuousWebJob>> GetIfExistsAsync(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SiteContinuousWebJob> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteContinuousWebJob>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SiteContinuousWebJob> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteContinuousWebJob>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteDeployment : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteDeployment() { }
        public virtual Azure.ResourceManager.AppService.DeploymentData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string id) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteDeployment> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteDeployment>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteDeployment> GetDeploymentLog(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteDeployment>> GetDeploymentLogAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteDeploymentCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteDeployment>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteDeployment>, System.Collections.IEnumerable
    {
        protected SiteDeploymentCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteDeployment> CreateOrUpdate(Azure.WaitUntil waitUntil, string id, Azure.ResourceManager.AppService.DeploymentData deployment, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteDeployment>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string id, Azure.ResourceManager.AppService.DeploymentData deployment, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteDeployment> Get(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteDeployment> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteDeployment> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteDeployment>> GetAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteDeployment> GetIfExists(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteDeployment>> GetIfExistsAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SiteDeployment> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteDeployment>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SiteDeployment> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteDeployment>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteDetector : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteDetector() { }
        public virtual Azure.ResourceManager.AppService.AppServiceDetectorData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string siteName, string detectorName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteDetector> Get(System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteDetector>> GetAsync(System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteDetectorCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteDetector>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteDetector>, System.Collections.IEnumerable
    {
        protected SiteDetectorCollection() { }
        public virtual Azure.Response<bool> Exists(string detectorName, System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string detectorName, System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteDetector> Get(string detectorName, System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteDetector> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteDetector> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteDetector>> GetAsync(string detectorName, System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteDetector> GetIfExists(string detectorName, System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteDetector>> GetIfExistsAsync(string detectorName, System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SiteDetector> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteDetector>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SiteDetector> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteDetector>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteDiagnostic : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteDiagnostic() { }
        public virtual Azure.ResourceManager.AppService.DiagnosticCategoryData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string siteName, string diagnosticCategory) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteDiagnostic> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteDiagnostic>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteDiagnosticAnalysisCollection GetSiteDiagnosticAnalyses() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteDiagnosticAnalysis> GetSiteDiagnosticAnalysis(string analysisName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteDiagnosticAnalysis>> GetSiteDiagnosticAnalysisAsync(string analysisName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteDiagnosticDetector> GetSiteDiagnosticDetector(string detectorName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteDiagnosticDetector>> GetSiteDiagnosticDetectorAsync(string detectorName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteDiagnosticDetectorCollection GetSiteDiagnosticDetectors() { throw null; }
    }
    public partial class SiteDiagnosticAnalysis : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteDiagnosticAnalysis() { }
        public virtual Azure.ResourceManager.AppService.AnalysisDefinitionData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string siteName, string diagnosticCategory, string analysisName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.DiagnosticAnalysis> Execute(System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.DiagnosticAnalysis>> ExecuteAsync(System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteDiagnosticAnalysis> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteDiagnosticAnalysis>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteDiagnosticAnalysisCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteDiagnosticAnalysis>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteDiagnosticAnalysis>, System.Collections.IEnumerable
    {
        protected SiteDiagnosticAnalysisCollection() { }
        public virtual Azure.Response<bool> Exists(string analysisName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string analysisName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteDiagnosticAnalysis> Get(string analysisName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteDiagnosticAnalysis> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteDiagnosticAnalysis> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteDiagnosticAnalysis>> GetAsync(string analysisName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteDiagnosticAnalysis> GetIfExists(string analysisName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteDiagnosticAnalysis>> GetIfExistsAsync(string analysisName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SiteDiagnosticAnalysis> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteDiagnosticAnalysis>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SiteDiagnosticAnalysis> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteDiagnosticAnalysis>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteDiagnosticCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteDiagnostic>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteDiagnostic>, System.Collections.IEnumerable
    {
        protected SiteDiagnosticCollection() { }
        public virtual Azure.Response<bool> Exists(string diagnosticCategory, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string diagnosticCategory, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteDiagnostic> Get(string diagnosticCategory, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteDiagnostic> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteDiagnostic> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteDiagnostic>> GetAsync(string diagnosticCategory, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteDiagnostic> GetIfExists(string diagnosticCategory, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteDiagnostic>> GetIfExistsAsync(string diagnosticCategory, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SiteDiagnostic> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteDiagnostic>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SiteDiagnostic> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteDiagnostic>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteDiagnosticDetector : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteDiagnosticDetector() { }
        public virtual Azure.ResourceManager.AppService.DetectorDefinitionAutoGeneratedData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string siteName, string diagnosticCategory, string detectorName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.DiagnosticDetectorResponse> Execute(System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.DiagnosticDetectorResponse>> ExecuteAsync(System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteDiagnosticDetector> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteDiagnosticDetector>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteDiagnosticDetectorCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteDiagnosticDetector>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteDiagnosticDetector>, System.Collections.IEnumerable
    {
        protected SiteDiagnosticDetectorCollection() { }
        public virtual Azure.Response<bool> Exists(string detectorName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string detectorName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteDiagnosticDetector> Get(string detectorName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteDiagnosticDetector> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteDiagnosticDetector> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteDiagnosticDetector>> GetAsync(string detectorName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteDiagnosticDetector> GetIfExists(string detectorName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteDiagnosticDetector>> GetIfExistsAsync(string detectorName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SiteDiagnosticDetector> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteDiagnosticDetector>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SiteDiagnosticDetector> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteDiagnosticDetector>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteDomainOwnershipIdentifier : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteDomainOwnershipIdentifier() { }
        public virtual Azure.ResourceManager.AppService.IdentifierData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string domainOwnershipIdentifierName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteDomainOwnershipIdentifier> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteDomainOwnershipIdentifier>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteDomainOwnershipIdentifier> Update(Azure.ResourceManager.AppService.IdentifierData domainOwnershipIdentifier, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteDomainOwnershipIdentifier>> UpdateAsync(Azure.ResourceManager.AppService.IdentifierData domainOwnershipIdentifier, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteDomainOwnershipIdentifierCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteDomainOwnershipIdentifier>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteDomainOwnershipIdentifier>, System.Collections.IEnumerable
    {
        protected SiteDomainOwnershipIdentifierCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteDomainOwnershipIdentifier> CreateOrUpdate(Azure.WaitUntil waitUntil, string domainOwnershipIdentifierName, Azure.ResourceManager.AppService.IdentifierData domainOwnershipIdentifier, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteDomainOwnershipIdentifier>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string domainOwnershipIdentifierName, Azure.ResourceManager.AppService.IdentifierData domainOwnershipIdentifier, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string domainOwnershipIdentifierName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string domainOwnershipIdentifierName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteDomainOwnershipIdentifier> Get(string domainOwnershipIdentifierName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteDomainOwnershipIdentifier> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteDomainOwnershipIdentifier> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteDomainOwnershipIdentifier>> GetAsync(string domainOwnershipIdentifierName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteDomainOwnershipIdentifier> GetIfExists(string domainOwnershipIdentifierName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteDomainOwnershipIdentifier>> GetIfExistsAsync(string domainOwnershipIdentifierName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SiteDomainOwnershipIdentifier> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteDomainOwnershipIdentifier>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SiteDomainOwnershipIdentifier> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteDomainOwnershipIdentifier>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteExtension : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteExtension() { }
        public virtual Azure.ResourceManager.AppService.MSDeployStatusData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteExtension> CreateOrUpdate(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.Models.MsDeploy msDeploy, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteExtension>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.Models.MsDeploy msDeploy, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteExtension> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteExtension>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.MsDeployLog> GetMSDeployLog(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.MsDeployLog>> GetMSDeployLogAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteExtensionInfoData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public SiteExtensionInfoData() { }
        public System.Collections.Generic.IList<string> Authors { get { throw null; } }
        public string Comment { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public int? DownloadCount { get { throw null; } set { } }
        public string ExtensionId { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.SiteExtensionType? ExtensionType { get { throw null; } set { } }
        public string ExtensionUrl { get { throw null; } set { } }
        public string FeedUrl { get { throw null; } set { } }
        public string IconUrl { get { throw null; } set { } }
        public System.DateTimeOffset? InstalledDateTime { get { throw null; } set { } }
        public string InstallerCommandLineParams { get { throw null; } set { } }
        public string LicenseUrl { get { throw null; } set { } }
        public bool? LocalIsLatestVersion { get { throw null; } set { } }
        public string LocalPath { get { throw null; } set { } }
        public string ProjectUrl { get { throw null; } set { } }
        public string ProvisioningState { get { throw null; } set { } }
        public System.DateTimeOffset? PublishedDateTime { get { throw null; } set { } }
        public string Summary { get { throw null; } set { } }
        public string Title { get { throw null; } set { } }
        public string Version { get { throw null; } set { } }
    }
    public partial class SiteFunction : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteFunction() { }
        public virtual Azure.ResourceManager.AppService.FunctionEnvelopeData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.KeyInfo> CreateOrUpdateFunctionSecret(string keyName, Azure.ResourceManager.AppService.Models.KeyInfo key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.KeyInfo>> CreateOrUpdateFunctionSecretAsync(string keyName, Azure.ResourceManager.AppService.Models.KeyInfo key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string functionName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DeleteFunctionSecret(string keyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteFunctionSecretAsync(string keyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteFunction> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteFunction>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.StringDictionary> GetFunctionKeys(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.StringDictionary>> GetFunctionKeysAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.FunctionSecrets> GetFunctionSecrets(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.FunctionSecrets>> GetFunctionSecretsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteFunctionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteFunction>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteFunction>, System.Collections.IEnumerable
    {
        protected SiteFunctionCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteFunction> CreateOrUpdate(Azure.WaitUntil waitUntil, string functionName, Azure.ResourceManager.AppService.FunctionEnvelopeData functionEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteFunction>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string functionName, Azure.ResourceManager.AppService.FunctionEnvelopeData functionEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string functionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string functionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteFunction> Get(string functionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteFunction> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteFunction> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteFunction>> GetAsync(string functionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteFunction> GetIfExists(string functionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteFunction>> GetIfExistsAsync(string functionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SiteFunction> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteFunction>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SiteFunction> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteFunction>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteHostNameBinding : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteHostNameBinding() { }
        public virtual Azure.ResourceManager.AppService.HostNameBindingData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string hostName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteHostNameBinding> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteHostNameBinding>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteHostNameBindingCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteHostNameBinding>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteHostNameBinding>, System.Collections.IEnumerable
    {
        protected SiteHostNameBindingCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteHostNameBinding> CreateOrUpdate(Azure.WaitUntil waitUntil, string hostName, Azure.ResourceManager.AppService.HostNameBindingData hostNameBinding, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteHostNameBinding>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string hostName, Azure.ResourceManager.AppService.HostNameBindingData hostNameBinding, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string hostName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string hostName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteHostNameBinding> Get(string hostName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteHostNameBinding> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteHostNameBinding> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteHostNameBinding>> GetAsync(string hostName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteHostNameBinding> GetIfExists(string hostName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteHostNameBinding>> GetIfExistsAsync(string hostName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SiteHostNameBinding> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteHostNameBinding>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SiteHostNameBinding> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteHostNameBinding>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteHybridConnection : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteHybridConnection() { }
        public virtual Azure.ResourceManager.AppService.RelayServiceConnectionEntityData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string entityName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteHybridConnection> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteHybridConnection>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteHybridConnection> Update(Azure.ResourceManager.AppService.RelayServiceConnectionEntityData connectionEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteHybridConnection>> UpdateAsync(Azure.ResourceManager.AppService.RelayServiceConnectionEntityData connectionEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteHybridConnectionCollection : Azure.ResourceManager.ArmCollection
    {
        protected SiteHybridConnectionCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteHybridConnection> CreateOrUpdate(Azure.WaitUntil waitUntil, string entityName, Azure.ResourceManager.AppService.RelayServiceConnectionEntityData connectionEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteHybridConnection>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string entityName, Azure.ResourceManager.AppService.RelayServiceConnectionEntityData connectionEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string entityName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string entityName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteHybridConnection> Get(string entityName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteHybridConnection>> GetAsync(string entityName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteHybridConnection> GetIfExists(string entityName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteHybridConnection>> GetIfExistsAsync(string entityName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteHybridConnectionNamespaceRelay : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteHybridConnectionNamespaceRelay() { }
        public virtual Azure.ResourceManager.AppService.HybridConnectionData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string namespaceName, string relayName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteHybridConnectionNamespaceRelay> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteHybridConnectionNamespaceRelay>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteHybridConnectionNamespaceRelay> Update(Azure.ResourceManager.AppService.HybridConnectionData connectionEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteHybridConnectionNamespaceRelay>> UpdateAsync(Azure.ResourceManager.AppService.HybridConnectionData connectionEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteHybridConnectionNamespaceRelayCollection : Azure.ResourceManager.ArmCollection
    {
        protected SiteHybridConnectionNamespaceRelayCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteHybridConnectionNamespaceRelay> CreateOrUpdate(Azure.WaitUntil waitUntil, string namespaceName, string relayName, Azure.ResourceManager.AppService.HybridConnectionData connectionEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteHybridConnectionNamespaceRelay>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string namespaceName, string relayName, Azure.ResourceManager.AppService.HybridConnectionData connectionEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string namespaceName, string relayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string namespaceName, string relayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteHybridConnectionNamespaceRelay> Get(string namespaceName, string relayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteHybridConnectionNamespaceRelay>> GetAsync(string namespaceName, string relayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteHybridConnectionNamespaceRelay> GetIfExists(string namespaceName, string relayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteHybridConnectionNamespaceRelay>> GetIfExistsAsync(string namespaceName, string relayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteInstance : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteInstance() { }
        public virtual Azure.ResourceManager.AppService.WebSiteInstanceStatusData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string instanceId) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteInstance> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteInstance>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteInstanceExtension GetSiteInstanceExtension() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteInstanceProcess> GetSiteInstanceProcess(string processId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteInstanceProcess>> GetSiteInstanceProcessAsync(string processId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteInstanceProcessCollection GetSiteInstanceProcesses() { throw null; }
    }
    public partial class SiteInstanceCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteInstance>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteInstance>, System.Collections.IEnumerable
    {
        protected SiteInstanceCollection() { }
        public virtual Azure.Response<bool> Exists(string instanceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string instanceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteInstance> Get(string instanceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteInstance> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteInstance> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteInstance>> GetAsync(string instanceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteInstance> GetIfExists(string instanceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteInstance>> GetIfExistsAsync(string instanceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SiteInstance> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteInstance>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SiteInstance> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteInstance>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteInstanceExtension : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteInstanceExtension() { }
        public virtual Azure.ResourceManager.AppService.MSDeployStatusData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteInstanceExtension> CreateOrUpdate(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.Models.MsDeploy msDeploy, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteInstanceExtension>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.Models.MsDeploy msDeploy, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string instanceId) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteInstanceExtension> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteInstanceExtension>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.MsDeployLog> GetInstanceMSDeployLog(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.MsDeployLog>> GetInstanceMSDeployLogAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteInstanceProcess : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteInstanceProcess() { }
        public virtual Azure.ResourceManager.AppService.ProcessInfoData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string instanceId, string processId) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteInstanceProcess> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteInstanceProcess>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<System.IO.Stream> GetInstanceProcessDump(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.IO.Stream>> GetInstanceProcessDumpAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.ProcessThreadInfo> GetInstanceProcessThreads(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.ProcessThreadInfo> GetInstanceProcessThreadsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteInstanceProcessModule> GetSiteInstanceProcessModule(string baseAddress, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteInstanceProcessModule>> GetSiteInstanceProcessModuleAsync(string baseAddress, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteInstanceProcessModuleCollection GetSiteInstanceProcessModules() { throw null; }
    }
    public partial class SiteInstanceProcessCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteInstanceProcess>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteInstanceProcess>, System.Collections.IEnumerable
    {
        protected SiteInstanceProcessCollection() { }
        public virtual Azure.Response<bool> Exists(string processId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string processId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteInstanceProcess> Get(string processId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteInstanceProcess> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteInstanceProcess> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteInstanceProcess>> GetAsync(string processId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteInstanceProcess> GetIfExists(string processId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteInstanceProcess>> GetIfExistsAsync(string processId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SiteInstanceProcess> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteInstanceProcess>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SiteInstanceProcess> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteInstanceProcess>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteInstanceProcessModule : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteInstanceProcessModule() { }
        public virtual Azure.ResourceManager.AppService.ProcessModuleInfoData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string instanceId, string processId, string baseAddress) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteInstanceProcessModule> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteInstanceProcessModule>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteInstanceProcessModuleCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteInstanceProcessModule>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteInstanceProcessModule>, System.Collections.IEnumerable
    {
        protected SiteInstanceProcessModuleCollection() { }
        public virtual Azure.Response<bool> Exists(string baseAddress, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string baseAddress, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteInstanceProcessModule> Get(string baseAddress, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteInstanceProcessModule> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteInstanceProcessModule> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteInstanceProcessModule>> GetAsync(string baseAddress, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteInstanceProcessModule> GetIfExists(string baseAddress, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteInstanceProcessModule>> GetIfExistsAsync(string baseAddress, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SiteInstanceProcessModule> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteInstanceProcessModule>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SiteInstanceProcessModule> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteInstanceProcessModule>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteLogsConfigData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public SiteLogsConfigData() { }
        public Azure.ResourceManager.AppService.Models.ApplicationLogsConfig ApplicationLogs { get { throw null; } set { } }
        public bool? DetailedErrorMessagesEnabled { get { throw null; } set { } }
        public bool? FailedRequestsTracingEnabled { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.HttpLogsConfig HttpLogs { get { throw null; } set { } }
    }
    public partial class SiteNetworkConfig : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteNetworkConfig() { }
        public virtual Azure.ResourceManager.AppService.SwiftVirtualNetworkData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteNetworkConfig> CreateOrUpdate(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.SwiftVirtualNetworkData connectionEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteNetworkConfig>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.SwiftVirtualNetworkData connectionEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteNetworkConfig> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteNetworkConfig>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteNetworkConfig> Update(Azure.ResourceManager.AppService.SwiftVirtualNetworkData connectionEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteNetworkConfig>> UpdateAsync(Azure.ResourceManager.AppService.SwiftVirtualNetworkData connectionEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SitePremierAddon : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SitePremierAddon() { }
        public virtual Azure.ResourceManager.AppService.PremierAddOnData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SitePremierAddon> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SitePremierAddon>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string premierAddOnName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SitePremierAddon> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SitePremierAddon>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SitePremierAddon> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SitePremierAddon>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SitePremierAddon> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SitePremierAddon>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SitePremierAddon> Update(Azure.ResourceManager.AppService.Models.PremierAddOnPatchResource premierAddOn, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SitePremierAddon>> UpdateAsync(Azure.ResourceManager.AppService.Models.PremierAddOnPatchResource premierAddOn, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SitePremierAddonCollection : Azure.ResourceManager.ArmCollection
    {
        protected SitePremierAddonCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SitePremierAddon> CreateOrUpdate(Azure.WaitUntil waitUntil, string premierAddOnName, Azure.ResourceManager.AppService.PremierAddOnData premierAddOn, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SitePremierAddon>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string premierAddOnName, Azure.ResourceManager.AppService.PremierAddOnData premierAddOn, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string premierAddOnName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string premierAddOnName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SitePremierAddon> Get(string premierAddOnName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SitePremierAddon>> GetAsync(string premierAddOnName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SitePremierAddon> GetIfExists(string premierAddOnName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SitePremierAddon>> GetIfExistsAsync(string premierAddOnName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SitePrivateAccess : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SitePrivateAccess() { }
        public virtual Azure.ResourceManager.AppService.PrivateAccessData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SitePrivateAccess> CreateOrUpdate(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.PrivateAccessData access, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SitePrivateAccess>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.PrivateAccessData access, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SitePrivateAccess> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SitePrivateAccess>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SitePrivateEndpointConnection : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SitePrivateEndpointConnection() { }
        public virtual Azure.ResourceManager.AppService.RemotePrivateEndpointConnectionARMResourceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string privateEndpointConnectionName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<System.BinaryData> Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<System.BinaryData>> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SitePrivateEndpointConnection> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SitePrivateEndpointConnection>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SitePrivateEndpointConnectionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SitePrivateEndpointConnection>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SitePrivateEndpointConnection>, System.Collections.IEnumerable
    {
        protected SitePrivateEndpointConnectionCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SitePrivateEndpointConnection> CreateOrUpdate(Azure.WaitUntil waitUntil, string privateEndpointConnectionName, Azure.ResourceManager.AppService.Models.PrivateLinkConnectionApprovalRequestResource privateEndpointWrapper, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SitePrivateEndpointConnection>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string privateEndpointConnectionName, Azure.ResourceManager.AppService.Models.PrivateLinkConnectionApprovalRequestResource privateEndpointWrapper, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SitePrivateEndpointConnection> Get(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SitePrivateEndpointConnection> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SitePrivateEndpointConnection> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SitePrivateEndpointConnection>> GetAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SitePrivateEndpointConnection> GetIfExists(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SitePrivateEndpointConnection>> GetIfExistsAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SitePrivateEndpointConnection> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SitePrivateEndpointConnection>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SitePrivateEndpointConnection> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SitePrivateEndpointConnection>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteProcess : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteProcess() { }
        public virtual Azure.ResourceManager.AppService.ProcessInfoData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string processId) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteProcess> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteProcess>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<System.IO.Stream> GetProcessDump(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.IO.Stream>> GetProcessDumpAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.ProcessThreadInfo> GetProcessThreads(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.ProcessThreadInfo> GetProcessThreadsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteProcessModule> GetSiteProcessModule(string baseAddress, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteProcessModule>> GetSiteProcessModuleAsync(string baseAddress, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteProcessModuleCollection GetSiteProcessModules() { throw null; }
    }
    public partial class SiteProcessCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteProcess>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteProcess>, System.Collections.IEnumerable
    {
        protected SiteProcessCollection() { }
        public virtual Azure.Response<bool> Exists(string processId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string processId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteProcess> Get(string processId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteProcess> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteProcess> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteProcess>> GetAsync(string processId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteProcess> GetIfExists(string processId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteProcess>> GetIfExistsAsync(string processId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SiteProcess> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteProcess>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SiteProcess> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteProcess>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteProcessModule : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteProcessModule() { }
        public virtual Azure.ResourceManager.AppService.ProcessModuleInfoData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string processId, string baseAddress) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteProcessModule> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteProcessModule>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteProcessModuleCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteProcessModule>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteProcessModule>, System.Collections.IEnumerable
    {
        protected SiteProcessModuleCollection() { }
        public virtual Azure.Response<bool> Exists(string baseAddress, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string baseAddress, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteProcessModule> Get(string baseAddress, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteProcessModule> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteProcessModule> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteProcessModule>> GetAsync(string baseAddress, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteProcessModule> GetIfExists(string baseAddress, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteProcessModule>> GetIfExistsAsync(string baseAddress, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SiteProcessModule> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteProcessModule>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SiteProcessModule> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteProcessModule>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SitePublicCertificate : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SitePublicCertificate() { }
        public virtual Azure.ResourceManager.AppService.PublicCertificateData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string publicCertificateName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SitePublicCertificate> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SitePublicCertificate>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SitePublicCertificateCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SitePublicCertificate>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SitePublicCertificate>, System.Collections.IEnumerable
    {
        protected SitePublicCertificateCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SitePublicCertificate> CreateOrUpdate(Azure.WaitUntil waitUntil, string publicCertificateName, Azure.ResourceManager.AppService.PublicCertificateData publicCertificate, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SitePublicCertificate>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string publicCertificateName, Azure.ResourceManager.AppService.PublicCertificateData publicCertificate, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string publicCertificateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string publicCertificateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SitePublicCertificate> Get(string publicCertificateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SitePublicCertificate> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SitePublicCertificate> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SitePublicCertificate>> GetAsync(string publicCertificateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SitePublicCertificate> GetIfExists(string publicCertificateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SitePublicCertificate>> GetIfExistsAsync(string publicCertificateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SitePublicCertificate> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SitePublicCertificate>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SitePublicCertificate> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SitePublicCertificate>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteRecommendation : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteRecommendation() { }
        public virtual Azure.ResourceManager.AppService.RecommendationRuleData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string siteName, string name) { throw null; }
        public virtual Azure.Response Disable(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DisableAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteRecommendation> Get(bool? updateSeen = default(bool?), string recommendationId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteRecommendation>> GetAsync(bool? updateSeen = default(bool?), string recommendationId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteRecommendationCollection : Azure.ResourceManager.ArmCollection
    {
        protected SiteRecommendationCollection() { }
        public virtual Azure.Response<bool> Exists(string name, bool? updateSeen = default(bool?), string recommendationId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string name, bool? updateSeen = default(bool?), string recommendationId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteRecommendation> Get(string name, bool? updateSeen = default(bool?), string recommendationId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteRecommendation>> GetAsync(string name, bool? updateSeen = default(bool?), string recommendationId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteRecommendation> GetIfExists(string name, bool? updateSeen = default(bool?), string recommendationId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteRecommendation>> GetIfExistsAsync(string name, bool? updateSeen = default(bool?), string recommendationId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteResourceHealthMetadata : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteResourceHealthMetadata() { }
        public virtual Azure.ResourceManager.AppService.ResourceHealthMetadataData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteResourceHealthMetadata> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteResourceHealthMetadata>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteSiteextension : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteSiteextension() { }
        public virtual Azure.ResourceManager.AppService.SiteExtensionInfoData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string siteExtensionId) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSiteextension> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSiteextension>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteSiteextensionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSiteextension>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSiteextension>, System.Collections.IEnumerable
    {
        protected SiteSiteextensionCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteSiteextension> CreateOrUpdate(Azure.WaitUntil waitUntil, string siteExtensionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteSiteextension>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string siteExtensionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string siteExtensionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string siteExtensionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSiteextension> Get(string siteExtensionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteSiteextension> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteSiteextension> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSiteextension>> GetAsync(string siteExtensionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSiteextension> GetIfExists(string siteExtensionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSiteextension>> GetIfExistsAsync(string siteExtensionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SiteSiteextension> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSiteextension>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SiteSiteextension> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSiteextension>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteSlot : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteSlot() { }
        public virtual Azure.ResourceManager.AppService.WebSiteData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlot> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlot>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.CustomHostnameAnalysisResult> AnalyzeCustomHostnameSlot(string hostName = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.CustomHostnameAnalysisResult>> AnalyzeCustomHostnameSlotAsync(string hostName = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response ApplySlotConfigurationSlot(Azure.ResourceManager.AppService.Models.CsmSlotEntity slotSwapEntity, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> ApplySlotConfigurationSlotAsync(Azure.ResourceManager.AppService.Models.CsmSlotEntity slotSwapEntity, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteBackup> BackupSlot(Azure.ResourceManager.AppService.Models.BackupRequest request, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteBackup>> BackupSlotAsync(Azure.ResourceManager.AppService.Models.BackupRequest request, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.KeyInfo> CreateOrUpdateHostSecretSlot(string keyType, string keyName, Azure.ResourceManager.AppService.Models.KeyInfo key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.KeyInfo>> CreateOrUpdateHostSecretSlotAsync(string keyType, string keyName, Azure.ResourceManager.AppService.Models.KeyInfo key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, bool? deleteMetrics = default(bool?), bool? deleteEmptyServerFarm = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, bool? deleteMetrics = default(bool?), bool? deleteEmptyServerFarm = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DeleteBackupConfigurationSlot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteBackupConfigurationSlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DeleteHostSecretSlot(string keyType, string keyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteHostSecretSlotAsync(string keyType, string keyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.RestoreRequest> DiscoverBackupSlot(Azure.ResourceManager.AppService.Models.RestoreRequest request, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.RestoreRequest>> DiscoverBackupSlotAsync(Azure.ResourceManager.AppService.Models.RestoreRequest request, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GenerateNewSitePublishingPasswordSlot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GenerateNewSitePublishingPasswordSlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlot> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.StringDictionary> GetApplicationSettingsSlot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.StringDictionary>> GetApplicationSettingsSlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlot>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.SiteAuthSettings> GetAuthSettingsSlot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.SiteAuthSettings>> GetAuthSettingsSlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.SiteAuthSettingsV2> GetAuthSettingsV2Slot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.SiteAuthSettingsV2>> GetAuthSettingsV2SlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.AzureStoragePropertyDictionaryResource> GetAzureStorageAccountsSlot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.AzureStoragePropertyDictionaryResource>> GetAzureStorageAccountsSlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.BackupRequest> GetBackupConfigurationSlot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.BackupRequest>> GetBackupConfigurationSlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.WebSiteConfig> GetConfigurationsSlot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.WebSiteConfig> GetConfigurationsSlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.ConnectionStringDictionary> GetConnectionStringsSlot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.ConnectionStringDictionary>> GetConnectionStringsSlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<System.IO.Stream> GetContainerLogsZipSlot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.IO.Stream>> GetContainerLogsZipSlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.FtpSiteSlotBasicPublishingCredentialsPolicy GetFtpSiteSlotBasicPublishingCredentialsPolicy() { throw null; }
        public virtual Azure.Response<string> GetFunctionsAdminTokenSlot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<string>> GetFunctionsAdminTokenSlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.HostKeys> GetHostKeysSlot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.HostKeys>> GetHostKeysSlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.ServerfarmHybridConnectionNamespaceRelay> GetHybridConnectionsSlot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.ServerfarmHybridConnectionNamespaceRelay>> GetHybridConnectionsSlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.LogsSiteSlotConfig GetLogsSiteSlotConfig() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.StringDictionary> GetMetadataSlot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.StringDictionary>> GetMetadataSlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.MigrateMySqlStatus GetMigrateMySqlStatus() { throw null; }
        public virtual Azure.ResourceManager.AppService.NetworkFeaturesCollection GetNetworkFeatures() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.NetworkFeatures> GetNetworkFeatures(string view, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.NetworkFeatures>> GetNetworkFeaturesAsync(string view, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.NetworkTrace> GetNetworkTraceOperationSlot(string operationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.NetworkTrace> GetNetworkTraceOperationSlotAsync(string operationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.NetworkTrace> GetNetworkTraceOperationSlotV2(string operationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.NetworkTrace> GetNetworkTraceOperationSlotV2Async(string operationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.NetworkTrace> GetNetworkTracesSlot(string operationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.NetworkTrace> GetNetworkTracesSlotAsync(string operationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.NetworkTrace> GetNetworkTracesSlotV2(string operationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.NetworkTrace> GetNetworkTracesSlotV2Async(string operationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.PerfMonResponse> GetPerfMonCountersSlot(string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.PerfMonResponse> GetPerfMonCountersSlotAsync(string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SitePremierAddon> GetPremierAddOnsSlot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SitePremierAddon>> GetPremierAddOnsSlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.PrivateLinkResource> GetPrivateLinkResourcesSlot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.PrivateLinkResource> GetPrivateLinkResourcesSlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.User> GetPublishingCredentialsSlot(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.User>> GetPublishingCredentialsSlotAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<System.IO.Stream> GetPublishingProfileXmlWithSecretsSlot(Azure.ResourceManager.AppService.Models.CsmPublishingProfileOptions publishingProfileOptions, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.IO.Stream>> GetPublishingProfileXmlWithSecretsSlotAsync(Azure.ResourceManager.AppService.Models.CsmPublishingProfileOptions publishingProfileOptions, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteHybridConnection> GetRelayServiceConnectionsSlot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteHybridConnection>> GetRelayServiceConnectionsSlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.ScmSiteSlotBasicPublishingCredentialsPolicy GetScmSiteSlotBasicPublishingCredentialsPolicy() { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteBackup> GetSiteBackupsSlot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteBackup> GetSiteBackupsSlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.SitePhpErrorLogFlag> GetSitePhpErrorLogFlagSlot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.SitePhpErrorLogFlag>> GetSitePhpErrorLogFlagSlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.PushSettings> GetSitePushSettingsSlot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.PushSettings>> GetSitePushSettingsSlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotBackup> GetSiteSlotBackup(string backupId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotBackup>> GetSiteSlotBackupAsync(string backupId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteSlotBackupCollection GetSiteSlotBackups() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotConfigAppSetting> GetSiteSlotConfigAppSetting(string appSettingKey, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotConfigAppSetting>> GetSiteSlotConfigAppSettingAsync(string appSettingKey, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteSlotConfigAppSettingCollection GetSiteSlotConfigAppSettings() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotConfigConnectionString> GetSiteSlotConfigConnectionString(string connectionStringKey, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotConfigConnectionString>> GetSiteSlotConfigConnectionStringAsync(string connectionStringKey, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteSlotConfigConnectionStringCollection GetSiteSlotConfigConnectionStrings() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotContinuousWebJob> GetSiteSlotContinuousWebJob(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotContinuousWebJob>> GetSiteSlotContinuousWebJobAsync(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteSlotContinuousWebJobCollection GetSiteSlotContinuousWebJobs() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotDeployment> GetSiteSlotDeployment(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotDeployment>> GetSiteSlotDeploymentAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteSlotDeploymentCollection GetSiteSlotDeployments() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotDetector> GetSiteSlotDetector(string detectorName, System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotDetector>> GetSiteSlotDetectorAsync(string detectorName, System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteSlotDetectorCollection GetSiteSlotDetectors() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotDiagnostic> GetSiteSlotDiagnostic(string diagnosticCategory, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotDiagnostic>> GetSiteSlotDiagnosticAsync(string diagnosticCategory, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteSlotDiagnosticCollection GetSiteSlotDiagnostics() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotDomainOwnershipIdentifier> GetSiteSlotDomainOwnershipIdentifier(string domainOwnershipIdentifierName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotDomainOwnershipIdentifier>> GetSiteSlotDomainOwnershipIdentifierAsync(string domainOwnershipIdentifierName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteSlotDomainOwnershipIdentifierCollection GetSiteSlotDomainOwnershipIdentifiers() { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteSlotExtension GetSiteSlotExtension() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotFunction> GetSiteSlotFunction(string functionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotFunction>> GetSiteSlotFunctionAsync(string functionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteSlotFunctionCollection GetSiteSlotFunctions() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotHostNameBinding> GetSiteSlotHostNameBinding(string hostName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotHostNameBinding>> GetSiteSlotHostNameBindingAsync(string hostName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteSlotHostNameBindingCollection GetSiteSlotHostNameBindings() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotHybridconnection> GetSiteSlotHybridconnection(string entityName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotHybridconnection>> GetSiteSlotHybridconnectionAsync(string entityName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotHybridConnectionNamespaceRelay> GetSiteSlotHybridConnectionNamespaceRelay(string namespaceName, string relayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotHybridConnectionNamespaceRelay>> GetSiteSlotHybridConnectionNamespaceRelayAsync(string namespaceName, string relayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteSlotHybridConnectionNamespaceRelayCollection GetSiteSlotHybridConnectionNamespaceRelays() { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteSlotHybridconnectionCollection GetSiteSlotHybridconnections() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotInstance> GetSiteSlotInstance(string instanceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotInstance>> GetSiteSlotInstanceAsync(string instanceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteSlotInstanceCollection GetSiteSlotInstances() { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteSlotNetworkConfig GetSiteSlotNetworkConfig() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotPremierAddOn> GetSiteSlotPremierAddOn(string premierAddOnName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotPremierAddOn>> GetSiteSlotPremierAddOnAsync(string premierAddOnName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteSlotPremierAddOnCollection GetSiteSlotPremierAddOns() { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteSlotPrivateAccess GetSiteSlotPrivateAccess() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotPrivateEndpointConnection> GetSiteSlotPrivateEndpointConnection(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotPrivateEndpointConnection>> GetSiteSlotPrivateEndpointConnectionAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteSlotPrivateEndpointConnectionCollection GetSiteSlotPrivateEndpointConnections() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotProcess> GetSiteSlotProcess(string processId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotProcess>> GetSiteSlotProcessAsync(string processId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteSlotProcessCollection GetSiteSlotProcesses() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotPublicCertificate> GetSiteSlotPublicCertificate(string publicCertificateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotPublicCertificate>> GetSiteSlotPublicCertificateAsync(string publicCertificateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteSlotPublicCertificateCollection GetSiteSlotPublicCertificates() { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteSlotResourceHealthMetadata GetSiteSlotResourceHealthMetadata() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotSiteextension> GetSiteSlotSiteextension(string siteExtensionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotSiteextension>> GetSiteSlotSiteextensionAsync(string siteExtensionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteSlotSiteextensionCollection GetSiteSlotSiteextensions() { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteSlotSourcecontrol GetSiteSlotSourcecontrol() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotVirtualNetworkConnection> GetSiteSlotVirtualNetworkConnection(string vnetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotVirtualNetworkConnection>> GetSiteSlotVirtualNetworkConnectionAsync(string vnetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteSlotVirtualNetworkConnectionCollection GetSiteSlotVirtualNetworkConnections() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotWebJob> GetSiteSlotWebJob(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotWebJob>> GetSiteSlotWebJobAsync(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteSlotWebJobCollection GetSiteSlotWebJobs() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteTriggeredwebJob> GetSiteTriggeredwebJob(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteTriggeredwebJob>> GetSiteTriggeredwebJobAsync(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteTriggeredwebJobCollection GetSiteTriggeredwebJobs() { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.SlotDifference> GetSlotDifferencesSlot(Azure.ResourceManager.AppService.Models.CsmSlotEntity slotSwapEntity, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.SlotDifference> GetSlotDifferencesSlotAsync(Azure.ResourceManager.AppService.Models.CsmSlotEntity slotSwapEntity, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.Snapshot> GetSnapshotsFromDRSecondarySlot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.Snapshot> GetSnapshotsFromDRSecondarySlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.Snapshot> GetSnapshotsSlot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.Snapshot> GetSnapshotsSlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.FunctionSecrets> GetSyncFunctionTriggersSlot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.FunctionSecrets>> GetSyncFunctionTriggersSlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetSyncStatusSlot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetSyncStatusSlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.CsmUsageQuota> GetUsagesSlot(string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.CsmUsageQuota> GetUsagesSlotAsync(string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<System.IO.Stream> GetWebSiteContainerLogsSlot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.IO.Stream>> GetWebSiteContainerLogsSlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.WebSiteSlotConfig GetWebSiteSlotConfig() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.SiteCloneability> IsCloneableSlot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.SiteCloneability>> IsCloneableSlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlot> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlot>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response ResetSlotConfigurationSlot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> ResetSlotConfigurationSlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response RestartSlot(bool? softRestart = default(bool?), bool? synchronous = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> RestartSlotAsync(bool? softRestart = default(bool?), bool? synchronous = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation RestoreFromBackupBlobSlot(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.Models.RestoreRequest request, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> RestoreFromBackupBlobSlotAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.Models.RestoreRequest request, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation RestoreFromDeletedAppSlot(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.Models.DeletedAppRestoreRequest restoreRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> RestoreFromDeletedAppSlotAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.Models.DeletedAppRestoreRequest restoreRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation RestoreSnapshotSlot(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.Models.SnapshotRestoreRequest restoreRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> RestoreSnapshotSlotAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.Models.SnapshotRestoreRequest restoreRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlot> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlot>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.NetworkTrace>> StartNetworkTraceSlot(Azure.WaitUntil waitUntil, int? durationInSeconds = default(int?), int? maxFrameLength = default(int?), string sasUrl = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.NetworkTrace>>> StartNetworkTraceSlotAsync(Azure.WaitUntil waitUntil, int? durationInSeconds = default(int?), int? maxFrameLength = default(int?), string sasUrl = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response StartSlot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> StartSlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.NetworkTrace>> StartWebSiteNetworkTraceOperationSlot(Azure.WaitUntil waitUntil, int? durationInSeconds = default(int?), int? maxFrameLength = default(int?), string sasUrl = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.NetworkTrace>>> StartWebSiteNetworkTraceOperationSlotAsync(Azure.WaitUntil waitUntil, int? durationInSeconds = default(int?), int? maxFrameLength = default(int?), string sasUrl = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<string> StartWebSiteNetworkTraceSlot(int? durationInSeconds = default(int?), int? maxFrameLength = default(int?), string sasUrl = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<string>> StartWebSiteNetworkTraceSlotAsync(int? durationInSeconds = default(int?), int? maxFrameLength = default(int?), string sasUrl = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response StopNetworkTraceSlot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> StopNetworkTraceSlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response StopSlot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> StopSlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response StopWebSiteNetworkTraceSlot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> StopWebSiteNetworkTraceSlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation SwapSlot(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.Models.CsmSlotEntity slotSwapEntity, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> SwapSlotAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.Models.CsmSlotEntity slotSwapEntity, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response SyncFunctionsSlot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> SyncFunctionsSlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response SyncFunctionTriggersSlot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> SyncFunctionTriggersSlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response SyncRepositorySlot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> SyncRepositorySlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlot> Update(Azure.ResourceManager.AppService.Models.SitePatchResource siteEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.StringDictionary> UpdateApplicationSettingsSlot(Azure.ResourceManager.AppService.Models.StringDictionary appSettings, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.StringDictionary>> UpdateApplicationSettingsSlotAsync(Azure.ResourceManager.AppService.Models.StringDictionary appSettings, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlot>> UpdateAsync(Azure.ResourceManager.AppService.Models.SitePatchResource siteEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.SiteAuthSettings> UpdateAuthSettingsSlot(Azure.ResourceManager.AppService.Models.SiteAuthSettings siteAuthSettings, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.SiteAuthSettings>> UpdateAuthSettingsSlotAsync(Azure.ResourceManager.AppService.Models.SiteAuthSettings siteAuthSettings, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.SiteAuthSettingsV2> UpdateAuthSettingsV2Slot(Azure.ResourceManager.AppService.Models.SiteAuthSettingsV2 siteAuthSettingsV2, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.SiteAuthSettingsV2>> UpdateAuthSettingsV2SlotAsync(Azure.ResourceManager.AppService.Models.SiteAuthSettingsV2 siteAuthSettingsV2, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.AzureStoragePropertyDictionaryResource> UpdateAzureStorageAccountsSlot(Azure.ResourceManager.AppService.Models.AzureStoragePropertyDictionaryResource azureStorageAccounts, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.AzureStoragePropertyDictionaryResource>> UpdateAzureStorageAccountsSlotAsync(Azure.ResourceManager.AppService.Models.AzureStoragePropertyDictionaryResource azureStorageAccounts, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.BackupRequest> UpdateBackupConfigurationSlot(Azure.ResourceManager.AppService.Models.BackupRequest request, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.BackupRequest>> UpdateBackupConfigurationSlotAsync(Azure.ResourceManager.AppService.Models.BackupRequest request, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.ConnectionStringDictionary> UpdateConnectionStringsSlot(Azure.ResourceManager.AppService.Models.ConnectionStringDictionary connectionStrings, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.ConnectionStringDictionary>> UpdateConnectionStringsSlotAsync(Azure.ResourceManager.AppService.Models.ConnectionStringDictionary connectionStrings, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.StringDictionary> UpdateMetadataSlot(Azure.ResourceManager.AppService.Models.StringDictionary metadata, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.StringDictionary>> UpdateMetadataSlotAsync(Azure.ResourceManager.AppService.Models.StringDictionary metadata, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.PushSettings> UpdateSitePushSettingsSlot(Azure.ResourceManager.AppService.Models.PushSettings pushSettings, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.PushSettings>> UpdateSitePushSettingsSlotAsync(Azure.ResourceManager.AppService.Models.PushSettings pushSettings, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteSlotBackup : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteSlotBackup() { }
        public virtual Azure.ResourceManager.AppService.BackupItemData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot, string backupId) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotBackup> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotBackup>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotBackup> GetBackupStatusSecretsSlot(Azure.ResourceManager.AppService.Models.BackupRequest request, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotBackup>> GetBackupStatusSecretsSlotAsync(Azure.ResourceManager.AppService.Models.BackupRequest request, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation RestoreSlot(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.Models.RestoreRequest request, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> RestoreSlotAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.Models.RestoreRequest request, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteSlotBackupCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotBackup>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotBackup>, System.Collections.IEnumerable
    {
        protected SiteSlotBackupCollection() { }
        public virtual Azure.Response<bool> Exists(string backupId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string backupId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotBackup> Get(string backupId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteSlotBackup> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteSlotBackup> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotBackup>> GetAsync(string backupId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotBackup> GetIfExists(string backupId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotBackup>> GetIfExistsAsync(string backupId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SiteSlotBackup> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotBackup>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SiteSlotBackup> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotBackup>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteSlotCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlot>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlot>, System.Collections.IEnumerable
    {
        protected SiteSlotCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteSlot> CreateOrUpdate(Azure.WaitUntil waitUntil, string slot, Azure.ResourceManager.AppService.WebSiteData siteEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteSlot>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string slot, Azure.ResourceManager.AppService.WebSiteData siteEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string slot, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string slot, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlot> Get(string slot, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteSlot> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteSlot> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlot>> GetAsync(string slot, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlot> GetIfExists(string slot, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlot>> GetIfExistsAsync(string slot, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SiteSlot> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlot>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SiteSlot> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlot>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteSlotConfigAppSetting : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteSlotConfigAppSetting() { }
        public virtual Azure.ResourceManager.AppService.ApiKeyVaultReferenceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot, string appSettingKey) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotConfigAppSetting> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotConfigAppSetting>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteSlotConfigAppSettingCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotConfigAppSetting>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotConfigAppSetting>, System.Collections.IEnumerable
    {
        protected SiteSlotConfigAppSettingCollection() { }
        public virtual Azure.Response<bool> Exists(string appSettingKey, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string appSettingKey, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotConfigAppSetting> Get(string appSettingKey, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteSlotConfigAppSetting> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteSlotConfigAppSetting> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotConfigAppSetting>> GetAsync(string appSettingKey, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotConfigAppSetting> GetIfExists(string appSettingKey, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotConfigAppSetting>> GetIfExistsAsync(string appSettingKey, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SiteSlotConfigAppSetting> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotConfigAppSetting>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SiteSlotConfigAppSetting> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotConfigAppSetting>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteSlotConfigConnectionString : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteSlotConfigConnectionString() { }
        public virtual Azure.ResourceManager.AppService.ApiKeyVaultReferenceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot, string connectionStringKey) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotConfigConnectionString> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotConfigConnectionString>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteSlotConfigConnectionStringCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotConfigConnectionString>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotConfigConnectionString>, System.Collections.IEnumerable
    {
        protected SiteSlotConfigConnectionStringCollection() { }
        public virtual Azure.Response<bool> Exists(string connectionStringKey, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string connectionStringKey, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotConfigConnectionString> Get(string connectionStringKey, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteSlotConfigConnectionString> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteSlotConfigConnectionString> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotConfigConnectionString>> GetAsync(string connectionStringKey, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotConfigConnectionString> GetIfExists(string connectionStringKey, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotConfigConnectionString>> GetIfExistsAsync(string connectionStringKey, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SiteSlotConfigConnectionString> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotConfigConnectionString>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SiteSlotConfigConnectionString> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotConfigConnectionString>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteSlotConfigSnapshot : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteSlotConfigSnapshot() { }
        public virtual Azure.ResourceManager.AppService.SiteConfigData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot, string snapshotId) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotConfigSnapshot> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotConfigSnapshot>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response RecoverSiteConfigurationSnapshotSlot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> RecoverSiteConfigurationSnapshotSlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteSlotConfigSnapshotCollection : Azure.ResourceManager.ArmCollection
    {
        protected SiteSlotConfigSnapshotCollection() { }
        public virtual Azure.Response<bool> Exists(string snapshotId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string snapshotId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotConfigSnapshot> Get(string snapshotId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotConfigSnapshot>> GetAsync(string snapshotId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotConfigSnapshot> GetIfExists(string snapshotId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotConfigSnapshot>> GetIfExistsAsync(string snapshotId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteSlotContinuousWebJob : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteSlotContinuousWebJob() { }
        public virtual Azure.ResourceManager.AppService.ContinuousWebJobData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot, string webJobName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotContinuousWebJob> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotContinuousWebJob>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response StartContinuousWebJobSlot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> StartContinuousWebJobSlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response StopContinuousWebJobSlot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> StopContinuousWebJobSlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteSlotContinuousWebJobCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotContinuousWebJob>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotContinuousWebJob>, System.Collections.IEnumerable
    {
        protected SiteSlotContinuousWebJobCollection() { }
        public virtual Azure.Response<bool> Exists(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotContinuousWebJob> Get(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteSlotContinuousWebJob> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteSlotContinuousWebJob> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotContinuousWebJob>> GetAsync(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotContinuousWebJob> GetIfExists(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotContinuousWebJob>> GetIfExistsAsync(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SiteSlotContinuousWebJob> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotContinuousWebJob>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SiteSlotContinuousWebJob> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotContinuousWebJob>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteSlotDeployment : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteSlotDeployment() { }
        public virtual Azure.ResourceManager.AppService.DeploymentData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot, string id) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotDeployment> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotDeployment>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotDeployment> GetDeploymentLogSlot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotDeployment>> GetDeploymentLogSlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteSlotDeploymentCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotDeployment>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotDeployment>, System.Collections.IEnumerable
    {
        protected SiteSlotDeploymentCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteSlotDeployment> CreateOrUpdate(Azure.WaitUntil waitUntil, string id, Azure.ResourceManager.AppService.DeploymentData deployment, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteSlotDeployment>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string id, Azure.ResourceManager.AppService.DeploymentData deployment, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotDeployment> Get(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteSlotDeployment> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteSlotDeployment> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotDeployment>> GetAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotDeployment> GetIfExists(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotDeployment>> GetIfExistsAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SiteSlotDeployment> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotDeployment>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SiteSlotDeployment> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotDeployment>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteSlotDetector : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteSlotDetector() { }
        public virtual Azure.ResourceManager.AppService.AppServiceDetectorData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string siteName, string slot, string detectorName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotDetector> Get(System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotDetector>> GetAsync(System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteSlotDetectorCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotDetector>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotDetector>, System.Collections.IEnumerable
    {
        protected SiteSlotDetectorCollection() { }
        public virtual Azure.Response<bool> Exists(string detectorName, System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string detectorName, System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotDetector> Get(string detectorName, System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteSlotDetector> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteSlotDetector> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotDetector>> GetAsync(string detectorName, System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotDetector> GetIfExists(string detectorName, System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotDetector>> GetIfExistsAsync(string detectorName, System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SiteSlotDetector> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotDetector>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SiteSlotDetector> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotDetector>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteSlotDiagnostic : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteSlotDiagnostic() { }
        public virtual Azure.ResourceManager.AppService.DiagnosticCategoryData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string siteName, string slot, string diagnosticCategory) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotDiagnostic> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotDiagnostic>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteSlotDiagnosticAnalysisCollection GetSiteSlotDiagnosticAnalyses() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotDiagnosticAnalysis> GetSiteSlotDiagnosticAnalysis(string analysisName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotDiagnosticAnalysis>> GetSiteSlotDiagnosticAnalysisAsync(string analysisName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotDiagnosticDetector> GetSiteSlotDiagnosticDetector(string detectorName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotDiagnosticDetector>> GetSiteSlotDiagnosticDetectorAsync(string detectorName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteSlotDiagnosticDetectorCollection GetSiteSlotDiagnosticDetectors() { throw null; }
    }
    public partial class SiteSlotDiagnosticAnalysis : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteSlotDiagnosticAnalysis() { }
        public virtual Azure.ResourceManager.AppService.AnalysisDefinitionData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string siteName, string slot, string diagnosticCategory, string analysisName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.DiagnosticAnalysis> ExecuteSiteAnalysisSlot(System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.DiagnosticAnalysis>> ExecuteSiteAnalysisSlotAsync(System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotDiagnosticAnalysis> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotDiagnosticAnalysis>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteSlotDiagnosticAnalysisCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotDiagnosticAnalysis>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotDiagnosticAnalysis>, System.Collections.IEnumerable
    {
        protected SiteSlotDiagnosticAnalysisCollection() { }
        public virtual Azure.Response<bool> Exists(string analysisName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string analysisName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotDiagnosticAnalysis> Get(string analysisName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteSlotDiagnosticAnalysis> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteSlotDiagnosticAnalysis> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotDiagnosticAnalysis>> GetAsync(string analysisName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotDiagnosticAnalysis> GetIfExists(string analysisName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotDiagnosticAnalysis>> GetIfExistsAsync(string analysisName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SiteSlotDiagnosticAnalysis> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotDiagnosticAnalysis>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SiteSlotDiagnosticAnalysis> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotDiagnosticAnalysis>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteSlotDiagnosticCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotDiagnostic>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotDiagnostic>, System.Collections.IEnumerable
    {
        protected SiteSlotDiagnosticCollection() { }
        public virtual Azure.Response<bool> Exists(string diagnosticCategory, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string diagnosticCategory, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotDiagnostic> Get(string diagnosticCategory, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteSlotDiagnostic> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteSlotDiagnostic> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotDiagnostic>> GetAsync(string diagnosticCategory, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotDiagnostic> GetIfExists(string diagnosticCategory, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotDiagnostic>> GetIfExistsAsync(string diagnosticCategory, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SiteSlotDiagnostic> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotDiagnostic>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SiteSlotDiagnostic> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotDiagnostic>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteSlotDiagnosticDetector : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteSlotDiagnosticDetector() { }
        public virtual Azure.ResourceManager.AppService.DetectorDefinitionAutoGeneratedData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string siteName, string slot, string diagnosticCategory, string detectorName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.DiagnosticDetectorResponse> ExecuteSiteDetectorSlot(System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.DiagnosticDetectorResponse>> ExecuteSiteDetectorSlotAsync(System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotDiagnosticDetector> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotDiagnosticDetector>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteSlotDiagnosticDetectorCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotDiagnosticDetector>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotDiagnosticDetector>, System.Collections.IEnumerable
    {
        protected SiteSlotDiagnosticDetectorCollection() { }
        public virtual Azure.Response<bool> Exists(string detectorName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string detectorName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotDiagnosticDetector> Get(string detectorName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteSlotDiagnosticDetector> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteSlotDiagnosticDetector> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotDiagnosticDetector>> GetAsync(string detectorName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotDiagnosticDetector> GetIfExists(string detectorName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotDiagnosticDetector>> GetIfExistsAsync(string detectorName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SiteSlotDiagnosticDetector> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotDiagnosticDetector>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SiteSlotDiagnosticDetector> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotDiagnosticDetector>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteSlotDomainOwnershipIdentifier : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteSlotDomainOwnershipIdentifier() { }
        public virtual Azure.ResourceManager.AppService.IdentifierData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot, string domainOwnershipIdentifierName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotDomainOwnershipIdentifier> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotDomainOwnershipIdentifier>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotDomainOwnershipIdentifier> Update(Azure.ResourceManager.AppService.IdentifierData domainOwnershipIdentifier, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotDomainOwnershipIdentifier>> UpdateAsync(Azure.ResourceManager.AppService.IdentifierData domainOwnershipIdentifier, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteSlotDomainOwnershipIdentifierCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotDomainOwnershipIdentifier>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotDomainOwnershipIdentifier>, System.Collections.IEnumerable
    {
        protected SiteSlotDomainOwnershipIdentifierCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteSlotDomainOwnershipIdentifier> CreateOrUpdate(Azure.WaitUntil waitUntil, string domainOwnershipIdentifierName, Azure.ResourceManager.AppService.IdentifierData domainOwnershipIdentifier, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteSlotDomainOwnershipIdentifier>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string domainOwnershipIdentifierName, Azure.ResourceManager.AppService.IdentifierData domainOwnershipIdentifier, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string domainOwnershipIdentifierName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string domainOwnershipIdentifierName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotDomainOwnershipIdentifier> Get(string domainOwnershipIdentifierName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteSlotDomainOwnershipIdentifier> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteSlotDomainOwnershipIdentifier> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotDomainOwnershipIdentifier>> GetAsync(string domainOwnershipIdentifierName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotDomainOwnershipIdentifier> GetIfExists(string domainOwnershipIdentifierName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotDomainOwnershipIdentifier>> GetIfExistsAsync(string domainOwnershipIdentifierName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SiteSlotDomainOwnershipIdentifier> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotDomainOwnershipIdentifier>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SiteSlotDomainOwnershipIdentifier> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotDomainOwnershipIdentifier>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteSlotExtension : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteSlotExtension() { }
        public virtual Azure.ResourceManager.AppService.MSDeployStatusData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteSlotExtension> CreateOrUpdate(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.Models.MsDeploy msDeploy, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteSlotExtension>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.Models.MsDeploy msDeploy, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotExtension> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotExtension>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.MsDeployLog> GetMSDeployLogSlot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.MsDeployLog>> GetMSDeployLogSlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteSlotFunction : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteSlotFunction() { }
        public virtual Azure.ResourceManager.AppService.FunctionEnvelopeData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.KeyInfo> CreateOrUpdateFunctionSecretSlot(string keyName, Azure.ResourceManager.AppService.Models.KeyInfo key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.KeyInfo>> CreateOrUpdateFunctionSecretSlotAsync(string keyName, Azure.ResourceManager.AppService.Models.KeyInfo key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot, string functionName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DeleteFunctionSecretSlot(string keyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteFunctionSecretSlotAsync(string keyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotFunction> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotFunction>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.StringDictionary> GetFunctionKeysSlot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.StringDictionary>> GetFunctionKeysSlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.FunctionSecrets> GetFunctionSecretsSlot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.FunctionSecrets>> GetFunctionSecretsSlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteSlotFunctionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotFunction>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotFunction>, System.Collections.IEnumerable
    {
        protected SiteSlotFunctionCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteSlotFunction> CreateOrUpdate(Azure.WaitUntil waitUntil, string functionName, Azure.ResourceManager.AppService.FunctionEnvelopeData functionEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteSlotFunction>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string functionName, Azure.ResourceManager.AppService.FunctionEnvelopeData functionEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string functionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string functionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotFunction> Get(string functionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteSlotFunction> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteSlotFunction> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotFunction>> GetAsync(string functionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotFunction> GetIfExists(string functionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotFunction>> GetIfExistsAsync(string functionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SiteSlotFunction> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotFunction>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SiteSlotFunction> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotFunction>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteSlotHostNameBinding : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteSlotHostNameBinding() { }
        public virtual Azure.ResourceManager.AppService.HostNameBindingData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot, string hostName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotHostNameBinding> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotHostNameBinding>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteSlotHostNameBindingCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotHostNameBinding>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotHostNameBinding>, System.Collections.IEnumerable
    {
        protected SiteSlotHostNameBindingCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteSlotHostNameBinding> CreateOrUpdate(Azure.WaitUntil waitUntil, string hostName, Azure.ResourceManager.AppService.HostNameBindingData hostNameBinding, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteSlotHostNameBinding>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string hostName, Azure.ResourceManager.AppService.HostNameBindingData hostNameBinding, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string hostName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string hostName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotHostNameBinding> Get(string hostName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteSlotHostNameBinding> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteSlotHostNameBinding> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotHostNameBinding>> GetAsync(string hostName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotHostNameBinding> GetIfExists(string hostName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotHostNameBinding>> GetIfExistsAsync(string hostName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SiteSlotHostNameBinding> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotHostNameBinding>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SiteSlotHostNameBinding> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotHostNameBinding>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteSlotHybridconnection : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteSlotHybridconnection() { }
        public virtual Azure.ResourceManager.AppService.RelayServiceConnectionEntityData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot, string entityName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotHybridconnection> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotHybridconnection>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotHybridconnection> Update(Azure.ResourceManager.AppService.RelayServiceConnectionEntityData connectionEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotHybridconnection>> UpdateAsync(Azure.ResourceManager.AppService.RelayServiceConnectionEntityData connectionEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteSlotHybridconnectionCollection : Azure.ResourceManager.ArmCollection
    {
        protected SiteSlotHybridconnectionCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteSlotHybridconnection> CreateOrUpdate(Azure.WaitUntil waitUntil, string entityName, Azure.ResourceManager.AppService.RelayServiceConnectionEntityData connectionEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteSlotHybridconnection>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string entityName, Azure.ResourceManager.AppService.RelayServiceConnectionEntityData connectionEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string entityName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string entityName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotHybridconnection> Get(string entityName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotHybridconnection>> GetAsync(string entityName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotHybridconnection> GetIfExists(string entityName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotHybridconnection>> GetIfExistsAsync(string entityName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteSlotHybridConnectionNamespaceRelay : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteSlotHybridConnectionNamespaceRelay() { }
        public virtual Azure.ResourceManager.AppService.HybridConnectionData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot, string namespaceName, string relayName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotHybridConnectionNamespaceRelay> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotHybridConnectionNamespaceRelay>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotHybridConnectionNamespaceRelay> Update(Azure.ResourceManager.AppService.HybridConnectionData connectionEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotHybridConnectionNamespaceRelay>> UpdateAsync(Azure.ResourceManager.AppService.HybridConnectionData connectionEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteSlotHybridConnectionNamespaceRelayCollection : Azure.ResourceManager.ArmCollection
    {
        protected SiteSlotHybridConnectionNamespaceRelayCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteSlotHybridConnectionNamespaceRelay> CreateOrUpdate(Azure.WaitUntil waitUntil, string namespaceName, string relayName, Azure.ResourceManager.AppService.HybridConnectionData connectionEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteSlotHybridConnectionNamespaceRelay>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string namespaceName, string relayName, Azure.ResourceManager.AppService.HybridConnectionData connectionEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string namespaceName, string relayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string namespaceName, string relayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotHybridConnectionNamespaceRelay> Get(string namespaceName, string relayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotHybridConnectionNamespaceRelay>> GetAsync(string namespaceName, string relayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotHybridConnectionNamespaceRelay> GetIfExists(string namespaceName, string relayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotHybridConnectionNamespaceRelay>> GetIfExistsAsync(string namespaceName, string relayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteSlotInstance : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteSlotInstance() { }
        public virtual Azure.ResourceManager.AppService.WebSiteInstanceStatusData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot, string instanceId) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotInstance> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotInstance>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteSlotInstanceExtension GetSiteSlotInstanceExtension() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotInstanceProcess> GetSiteSlotInstanceProcess(string processId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotInstanceProcess>> GetSiteSlotInstanceProcessAsync(string processId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteSlotInstanceProcessCollection GetSiteSlotInstanceProcesses() { throw null; }
    }
    public partial class SiteSlotInstanceCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotInstance>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotInstance>, System.Collections.IEnumerable
    {
        protected SiteSlotInstanceCollection() { }
        public virtual Azure.Response<bool> Exists(string instanceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string instanceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotInstance> Get(string instanceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteSlotInstance> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteSlotInstance> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotInstance>> GetAsync(string instanceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotInstance> GetIfExists(string instanceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotInstance>> GetIfExistsAsync(string instanceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SiteSlotInstance> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotInstance>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SiteSlotInstance> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotInstance>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteSlotInstanceExtension : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteSlotInstanceExtension() { }
        public virtual Azure.ResourceManager.AppService.MSDeployStatusData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteSlotInstanceExtension> CreateOrUpdate(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.Models.MsDeploy msDeploy, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteSlotInstanceExtension>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.Models.MsDeploy msDeploy, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot, string instanceId) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotInstanceExtension> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotInstanceExtension>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.MsDeployLog> GetInstanceMSDeployLogSlot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.MsDeployLog>> GetInstanceMSDeployLogSlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteSlotInstanceProcess : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteSlotInstanceProcess() { }
        public virtual Azure.ResourceManager.AppService.ProcessInfoData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot, string instanceId, string processId) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotInstanceProcess> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotInstanceProcess>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<System.IO.Stream> GetInstanceProcessDumpSlot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.IO.Stream>> GetInstanceProcessDumpSlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.ProcessThreadInfo> GetInstanceProcessThreadsSlot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.ProcessThreadInfo> GetInstanceProcessThreadsSlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotInstanceProcessModule> GetSiteSlotInstanceProcessModule(string baseAddress, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotInstanceProcessModule>> GetSiteSlotInstanceProcessModuleAsync(string baseAddress, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteSlotInstanceProcessModuleCollection GetSiteSlotInstanceProcessModules() { throw null; }
    }
    public partial class SiteSlotInstanceProcessCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotInstanceProcess>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotInstanceProcess>, System.Collections.IEnumerable
    {
        protected SiteSlotInstanceProcessCollection() { }
        public virtual Azure.Response<bool> Exists(string processId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string processId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotInstanceProcess> Get(string processId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteSlotInstanceProcess> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteSlotInstanceProcess> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotInstanceProcess>> GetAsync(string processId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotInstanceProcess> GetIfExists(string processId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotInstanceProcess>> GetIfExistsAsync(string processId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SiteSlotInstanceProcess> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotInstanceProcess>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SiteSlotInstanceProcess> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotInstanceProcess>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteSlotInstanceProcessModule : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteSlotInstanceProcessModule() { }
        public virtual Azure.ResourceManager.AppService.ProcessModuleInfoData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot, string instanceId, string processId, string baseAddress) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotInstanceProcessModule> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotInstanceProcessModule>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteSlotInstanceProcessModuleCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotInstanceProcessModule>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotInstanceProcessModule>, System.Collections.IEnumerable
    {
        protected SiteSlotInstanceProcessModuleCollection() { }
        public virtual Azure.Response<bool> Exists(string baseAddress, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string baseAddress, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotInstanceProcessModule> Get(string baseAddress, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteSlotInstanceProcessModule> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteSlotInstanceProcessModule> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotInstanceProcessModule>> GetAsync(string baseAddress, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotInstanceProcessModule> GetIfExists(string baseAddress, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotInstanceProcessModule>> GetIfExistsAsync(string baseAddress, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SiteSlotInstanceProcessModule> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotInstanceProcessModule>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SiteSlotInstanceProcessModule> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotInstanceProcessModule>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteSlotNetworkConfig : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteSlotNetworkConfig() { }
        public virtual Azure.ResourceManager.AppService.SwiftVirtualNetworkData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteSlotNetworkConfig> CreateOrUpdate(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.SwiftVirtualNetworkData connectionEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteSlotNetworkConfig>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.SwiftVirtualNetworkData connectionEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotNetworkConfig> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotNetworkConfig>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotNetworkConfig> Update(Azure.ResourceManager.AppService.SwiftVirtualNetworkData connectionEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotNetworkConfig>> UpdateAsync(Azure.ResourceManager.AppService.SwiftVirtualNetworkData connectionEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteSlotPremierAddOn : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteSlotPremierAddOn() { }
        public virtual Azure.ResourceManager.AppService.PremierAddOnData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotPremierAddOn> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotPremierAddOn>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot, string premierAddOnName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotPremierAddOn> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotPremierAddOn>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotPremierAddOn> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotPremierAddOn>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotPremierAddOn> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotPremierAddOn>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotPremierAddOn> Update(Azure.ResourceManager.AppService.Models.PremierAddOnPatchResource premierAddOn, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotPremierAddOn>> UpdateAsync(Azure.ResourceManager.AppService.Models.PremierAddOnPatchResource premierAddOn, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteSlotPremierAddOnCollection : Azure.ResourceManager.ArmCollection
    {
        protected SiteSlotPremierAddOnCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteSlotPremierAddOn> CreateOrUpdate(Azure.WaitUntil waitUntil, string premierAddOnName, Azure.ResourceManager.AppService.PremierAddOnData premierAddOn, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteSlotPremierAddOn>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string premierAddOnName, Azure.ResourceManager.AppService.PremierAddOnData premierAddOn, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string premierAddOnName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string premierAddOnName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotPremierAddOn> Get(string premierAddOnName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotPremierAddOn>> GetAsync(string premierAddOnName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotPremierAddOn> GetIfExists(string premierAddOnName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotPremierAddOn>> GetIfExistsAsync(string premierAddOnName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteSlotPrivateAccess : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteSlotPrivateAccess() { }
        public virtual Azure.ResourceManager.AppService.PrivateAccessData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteSlotPrivateAccess> CreateOrUpdate(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.PrivateAccessData access, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteSlotPrivateAccess>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.PrivateAccessData access, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotPrivateAccess> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotPrivateAccess>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteSlotPrivateEndpointConnection : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteSlotPrivateEndpointConnection() { }
        public virtual Azure.ResourceManager.AppService.RemotePrivateEndpointConnectionARMResourceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot, string privateEndpointConnectionName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<System.BinaryData> Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<System.BinaryData>> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotPrivateEndpointConnection> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotPrivateEndpointConnection>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteSlotPrivateEndpointConnectionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotPrivateEndpointConnection>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotPrivateEndpointConnection>, System.Collections.IEnumerable
    {
        protected SiteSlotPrivateEndpointConnectionCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteSlotPrivateEndpointConnection> CreateOrUpdate(Azure.WaitUntil waitUntil, string privateEndpointConnectionName, Azure.ResourceManager.AppService.Models.PrivateLinkConnectionApprovalRequestResource privateEndpointWrapper, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteSlotPrivateEndpointConnection>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string privateEndpointConnectionName, Azure.ResourceManager.AppService.Models.PrivateLinkConnectionApprovalRequestResource privateEndpointWrapper, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotPrivateEndpointConnection> Get(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteSlotPrivateEndpointConnection> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteSlotPrivateEndpointConnection> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotPrivateEndpointConnection>> GetAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotPrivateEndpointConnection> GetIfExists(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotPrivateEndpointConnection>> GetIfExistsAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SiteSlotPrivateEndpointConnection> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotPrivateEndpointConnection>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SiteSlotPrivateEndpointConnection> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotPrivateEndpointConnection>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteSlotProcess : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteSlotProcess() { }
        public virtual Azure.ResourceManager.AppService.ProcessInfoData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot, string processId) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotProcess> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotProcess>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<System.IO.Stream> GetProcessDumpSlot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.IO.Stream>> GetProcessDumpSlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.ProcessThreadInfo> GetProcessThreadsSlot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.ProcessThreadInfo> GetProcessThreadsSlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotProcessModule> GetSiteSlotProcessModule(string baseAddress, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotProcessModule>> GetSiteSlotProcessModuleAsync(string baseAddress, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteSlotProcessModuleCollection GetSiteSlotProcessModules() { throw null; }
    }
    public partial class SiteSlotProcessCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotProcess>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotProcess>, System.Collections.IEnumerable
    {
        protected SiteSlotProcessCollection() { }
        public virtual Azure.Response<bool> Exists(string processId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string processId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotProcess> Get(string processId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteSlotProcess> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteSlotProcess> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotProcess>> GetAsync(string processId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotProcess> GetIfExists(string processId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotProcess>> GetIfExistsAsync(string processId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SiteSlotProcess> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotProcess>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SiteSlotProcess> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotProcess>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteSlotProcessModule : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteSlotProcessModule() { }
        public virtual Azure.ResourceManager.AppService.ProcessModuleInfoData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot, string processId, string baseAddress) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotProcessModule> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotProcessModule>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteSlotProcessModuleCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotProcessModule>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotProcessModule>, System.Collections.IEnumerable
    {
        protected SiteSlotProcessModuleCollection() { }
        public virtual Azure.Response<bool> Exists(string baseAddress, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string baseAddress, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotProcessModule> Get(string baseAddress, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteSlotProcessModule> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteSlotProcessModule> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotProcessModule>> GetAsync(string baseAddress, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotProcessModule> GetIfExists(string baseAddress, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotProcessModule>> GetIfExistsAsync(string baseAddress, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SiteSlotProcessModule> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotProcessModule>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SiteSlotProcessModule> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotProcessModule>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteSlotPublicCertificate : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteSlotPublicCertificate() { }
        public virtual Azure.ResourceManager.AppService.PublicCertificateData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot, string publicCertificateName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotPublicCertificate> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotPublicCertificate>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteSlotPublicCertificateCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotPublicCertificate>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotPublicCertificate>, System.Collections.IEnumerable
    {
        protected SiteSlotPublicCertificateCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteSlotPublicCertificate> CreateOrUpdate(Azure.WaitUntil waitUntil, string publicCertificateName, Azure.ResourceManager.AppService.PublicCertificateData publicCertificate, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteSlotPublicCertificate>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string publicCertificateName, Azure.ResourceManager.AppService.PublicCertificateData publicCertificate, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string publicCertificateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string publicCertificateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotPublicCertificate> Get(string publicCertificateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteSlotPublicCertificate> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteSlotPublicCertificate> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotPublicCertificate>> GetAsync(string publicCertificateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotPublicCertificate> GetIfExists(string publicCertificateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotPublicCertificate>> GetIfExistsAsync(string publicCertificateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SiteSlotPublicCertificate> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotPublicCertificate>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SiteSlotPublicCertificate> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotPublicCertificate>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteSlotResourceHealthMetadata : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteSlotResourceHealthMetadata() { }
        public virtual Azure.ResourceManager.AppService.ResourceHealthMetadataData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotResourceHealthMetadata> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotResourceHealthMetadata>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteSlotSiteextension : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteSlotSiteextension() { }
        public virtual Azure.ResourceManager.AppService.SiteExtensionInfoData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot, string siteExtensionId) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotSiteextension> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotSiteextension>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteSlotSiteextensionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotSiteextension>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotSiteextension>, System.Collections.IEnumerable
    {
        protected SiteSlotSiteextensionCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteSlotSiteextension> CreateOrUpdate(Azure.WaitUntil waitUntil, string siteExtensionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteSlotSiteextension>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string siteExtensionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string siteExtensionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string siteExtensionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotSiteextension> Get(string siteExtensionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteSlotSiteextension> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteSlotSiteextension> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotSiteextension>> GetAsync(string siteExtensionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotSiteextension> GetIfExists(string siteExtensionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotSiteextension>> GetIfExistsAsync(string siteExtensionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SiteSlotSiteextension> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotSiteextension>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SiteSlotSiteextension> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotSiteextension>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteSlotSourcecontrol : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteSlotSourcecontrol() { }
        public virtual Azure.ResourceManager.AppService.SiteSourceControlData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteSlotSourcecontrol> CreateOrUpdate(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.SiteSourceControlData siteSourceControl, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteSlotSourcecontrol>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.SiteSourceControlData siteSourceControl, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, string additionalFlags = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, string additionalFlags = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotSourcecontrol> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotSourcecontrol>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotSourcecontrol> Update(Azure.ResourceManager.AppService.SiteSourceControlData siteSourceControl, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotSourcecontrol>> UpdateAsync(Azure.ResourceManager.AppService.SiteSourceControlData siteSourceControl, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteSlotTriggeredWebJob : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteSlotTriggeredWebJob() { }
        public virtual Azure.ResourceManager.AppService.TriggeredWebJobData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string webJobName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotTriggeredWebJob> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotTriggeredWebJob>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteSlotTriggeredWebJobHistoryCollection GetSiteSlotTriggeredWebJobHistories() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotTriggeredWebJobHistory> GetSiteSlotTriggeredWebJobHistory(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotTriggeredWebJobHistory>> GetSiteSlotTriggeredWebJobHistoryAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response Run(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> RunAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteSlotTriggeredWebJobCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotTriggeredWebJob>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotTriggeredWebJob>, System.Collections.IEnumerable
    {
        protected SiteSlotTriggeredWebJobCollection() { }
        public virtual Azure.Response<bool> Exists(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotTriggeredWebJob> Get(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteSlotTriggeredWebJob> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteSlotTriggeredWebJob> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotTriggeredWebJob>> GetAsync(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotTriggeredWebJob> GetIfExists(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotTriggeredWebJob>> GetIfExistsAsync(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SiteSlotTriggeredWebJob> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotTriggeredWebJob>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SiteSlotTriggeredWebJob> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotTriggeredWebJob>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteSlotTriggeredWebJobHistory : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteSlotTriggeredWebJobHistory() { }
        public virtual Azure.ResourceManager.AppService.TriggeredJobHistoryData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string webJobName, string id) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotTriggeredWebJobHistory> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotTriggeredWebJobHistory>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteSlotTriggeredWebJobHistoryCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotTriggeredWebJobHistory>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotTriggeredWebJobHistory>, System.Collections.IEnumerable
    {
        protected SiteSlotTriggeredWebJobHistoryCollection() { }
        public virtual Azure.Response<bool> Exists(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotTriggeredWebJobHistory> Get(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteSlotTriggeredWebJobHistory> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteSlotTriggeredWebJobHistory> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotTriggeredWebJobHistory>> GetAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotTriggeredWebJobHistory> GetIfExists(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotTriggeredWebJobHistory>> GetIfExistsAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SiteSlotTriggeredWebJobHistory> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotTriggeredWebJobHistory>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SiteSlotTriggeredWebJobHistory> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotTriggeredWebJobHistory>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteSlotVirtualNetworkConnection : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteSlotVirtualNetworkConnection() { }
        public virtual Azure.ResourceManager.AppService.VnetInfoResourceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot, string vnetName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotVirtualNetworkConnection> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotVirtualNetworkConnection>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotVirtualNetworkConnectionGateway> GetSiteSlotVirtualNetworkConnectionGateway(string gatewayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotVirtualNetworkConnectionGateway>> GetSiteSlotVirtualNetworkConnectionGatewayAsync(string gatewayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteSlotVirtualNetworkConnectionGatewayCollection GetSiteSlotVirtualNetworkConnectionGateways() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotVirtualNetworkConnection> Update(Azure.ResourceManager.AppService.VnetInfoResourceData connectionEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotVirtualNetworkConnection>> UpdateAsync(Azure.ResourceManager.AppService.VnetInfoResourceData connectionEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteSlotVirtualNetworkConnectionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotVirtualNetworkConnection>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotVirtualNetworkConnection>, System.Collections.IEnumerable
    {
        protected SiteSlotVirtualNetworkConnectionCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteSlotVirtualNetworkConnection> CreateOrUpdate(Azure.WaitUntil waitUntil, string vnetName, Azure.ResourceManager.AppService.VnetInfoResourceData connectionEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteSlotVirtualNetworkConnection>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string vnetName, Azure.ResourceManager.AppService.VnetInfoResourceData connectionEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string vnetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string vnetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotVirtualNetworkConnection> Get(string vnetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteSlotVirtualNetworkConnection> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteSlotVirtualNetworkConnection> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotVirtualNetworkConnection>> GetAsync(string vnetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotVirtualNetworkConnection> GetIfExists(string vnetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotVirtualNetworkConnection>> GetIfExistsAsync(string vnetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SiteSlotVirtualNetworkConnection> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotVirtualNetworkConnection>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SiteSlotVirtualNetworkConnection> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotVirtualNetworkConnection>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteSlotVirtualNetworkConnectionGateway : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteSlotVirtualNetworkConnectionGateway() { }
        public virtual Azure.ResourceManager.AppService.VnetGatewayData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot, string vnetName, string gatewayName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotVirtualNetworkConnectionGateway> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotVirtualNetworkConnectionGateway>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotVirtualNetworkConnectionGateway> Update(Azure.ResourceManager.AppService.VnetGatewayData connectionEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotVirtualNetworkConnectionGateway>> UpdateAsync(Azure.ResourceManager.AppService.VnetGatewayData connectionEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteSlotVirtualNetworkConnectionGatewayCollection : Azure.ResourceManager.ArmCollection
    {
        protected SiteSlotVirtualNetworkConnectionGatewayCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteSlotVirtualNetworkConnectionGateway> CreateOrUpdate(Azure.WaitUntil waitUntil, string gatewayName, Azure.ResourceManager.AppService.VnetGatewayData connectionEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteSlotVirtualNetworkConnectionGateway>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string gatewayName, Azure.ResourceManager.AppService.VnetGatewayData connectionEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string gatewayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string gatewayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotVirtualNetworkConnectionGateway> Get(string gatewayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotVirtualNetworkConnectionGateway>> GetAsync(string gatewayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotVirtualNetworkConnectionGateway> GetIfExists(string gatewayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotVirtualNetworkConnectionGateway>> GetIfExistsAsync(string gatewayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteSlotWebJob : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteSlotWebJob() { }
        public virtual Azure.ResourceManager.AppService.WebJobData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot, string webJobName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotWebJob> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotWebJob>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteSlotWebJobCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotWebJob>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotWebJob>, System.Collections.IEnumerable
    {
        protected SiteSlotWebJobCollection() { }
        public virtual Azure.Response<bool> Exists(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotWebJob> Get(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteSlotWebJob> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteSlotWebJob> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotWebJob>> GetAsync(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotWebJob> GetIfExists(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotWebJob>> GetIfExistsAsync(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SiteSlotWebJob> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteSlotWebJob>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SiteSlotWebJob> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteSlotWebJob>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteSourceControl : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteSourceControl() { }
        public virtual Azure.ResourceManager.AppService.SiteSourceControlData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteSourceControl> CreateOrUpdate(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.SiteSourceControlData siteSourceControl, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteSourceControl>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.SiteSourceControlData siteSourceControl, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, string additionalFlags = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, string additionalFlags = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSourceControl> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSourceControl>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSourceControl> Update(Azure.ResourceManager.AppService.SiteSourceControlData siteSourceControl, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSourceControl>> UpdateAsync(Azure.ResourceManager.AppService.SiteSourceControlData siteSourceControl, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteSourceControlData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public SiteSourceControlData() { }
        public string Branch { get { throw null; } set { } }
        public bool? DeploymentRollbackEnabled { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.GitHubActionConfiguration GitHubActionConfiguration { get { throw null; } set { } }
        public bool? IsGitHubAction { get { throw null; } set { } }
        public bool? IsManualIntegration { get { throw null; } set { } }
        public bool? IsMercurial { get { throw null; } set { } }
        public string RepoUrl { get { throw null; } set { } }
    }
    public partial class SiteTriggeredwebJob : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteTriggeredwebJob() { }
        public virtual Azure.ResourceManager.AppService.TriggeredWebJobData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot, string webJobName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteTriggeredwebJob> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteTriggeredwebJob>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteTriggeredWebJobHistoryCollection GetSiteTriggeredWebJobHistories() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteTriggeredWebJobHistory> GetSiteTriggeredWebJobHistory(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteTriggeredWebJobHistory>> GetSiteTriggeredWebJobHistoryAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response RunTriggeredWebJobSlot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> RunTriggeredWebJobSlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteTriggeredwebJobCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteTriggeredwebJob>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteTriggeredwebJob>, System.Collections.IEnumerable
    {
        protected SiteTriggeredwebJobCollection() { }
        public virtual Azure.Response<bool> Exists(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteTriggeredwebJob> Get(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteTriggeredwebJob> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteTriggeredwebJob> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteTriggeredwebJob>> GetAsync(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteTriggeredwebJob> GetIfExists(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteTriggeredwebJob>> GetIfExistsAsync(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SiteTriggeredwebJob> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteTriggeredwebJob>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SiteTriggeredwebJob> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteTriggeredwebJob>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteTriggeredWebJobHistory : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteTriggeredWebJobHistory() { }
        public virtual Azure.ResourceManager.AppService.TriggeredJobHistoryData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot, string webJobName, string id) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteTriggeredWebJobHistory> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteTriggeredWebJobHistory>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteTriggeredWebJobHistoryCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteTriggeredWebJobHistory>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteTriggeredWebJobHistory>, System.Collections.IEnumerable
    {
        protected SiteTriggeredWebJobHistoryCollection() { }
        public virtual Azure.Response<bool> Exists(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteTriggeredWebJobHistory> Get(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteTriggeredWebJobHistory> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteTriggeredWebJobHistory> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteTriggeredWebJobHistory>> GetAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteTriggeredWebJobHistory> GetIfExists(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteTriggeredWebJobHistory>> GetIfExistsAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SiteTriggeredWebJobHistory> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteTriggeredWebJobHistory>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SiteTriggeredWebJobHistory> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteTriggeredWebJobHistory>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteVirtualNetworkConnection : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteVirtualNetworkConnection() { }
        public virtual Azure.ResourceManager.AppService.VnetInfoResourceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string vnetName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteVirtualNetworkConnection> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteVirtualNetworkConnection>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteVirtualNetworkConnectionGateway> GetSiteVirtualNetworkConnectionGateway(string gatewayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteVirtualNetworkConnectionGateway>> GetSiteVirtualNetworkConnectionGatewayAsync(string gatewayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteVirtualNetworkConnectionGatewayCollection GetSiteVirtualNetworkConnectionGateways() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteVirtualNetworkConnection> Update(Azure.ResourceManager.AppService.VnetInfoResourceData connectionEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteVirtualNetworkConnection>> UpdateAsync(Azure.ResourceManager.AppService.VnetInfoResourceData connectionEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteVirtualNetworkConnectionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteVirtualNetworkConnection>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteVirtualNetworkConnection>, System.Collections.IEnumerable
    {
        protected SiteVirtualNetworkConnectionCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteVirtualNetworkConnection> CreateOrUpdate(Azure.WaitUntil waitUntil, string vnetName, Azure.ResourceManager.AppService.VnetInfoResourceData connectionEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteVirtualNetworkConnection>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string vnetName, Azure.ResourceManager.AppService.VnetInfoResourceData connectionEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string vnetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string vnetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteVirtualNetworkConnection> Get(string vnetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteVirtualNetworkConnection> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteVirtualNetworkConnection> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteVirtualNetworkConnection>> GetAsync(string vnetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteVirtualNetworkConnection> GetIfExists(string vnetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteVirtualNetworkConnection>> GetIfExistsAsync(string vnetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SiteVirtualNetworkConnection> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteVirtualNetworkConnection>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SiteVirtualNetworkConnection> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteVirtualNetworkConnection>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteVirtualNetworkConnectionGateway : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteVirtualNetworkConnectionGateway() { }
        public virtual Azure.ResourceManager.AppService.VnetGatewayData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string vnetName, string gatewayName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteVirtualNetworkConnectionGateway> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteVirtualNetworkConnectionGateway>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteVirtualNetworkConnectionGateway> Update(Azure.ResourceManager.AppService.VnetGatewayData connectionEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteVirtualNetworkConnectionGateway>> UpdateAsync(Azure.ResourceManager.AppService.VnetGatewayData connectionEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteVirtualNetworkConnectionGatewayCollection : Azure.ResourceManager.ArmCollection
    {
        protected SiteVirtualNetworkConnectionGatewayCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteVirtualNetworkConnectionGateway> CreateOrUpdate(Azure.WaitUntil waitUntil, string gatewayName, Azure.ResourceManager.AppService.VnetGatewayData connectionEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SiteVirtualNetworkConnectionGateway>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string gatewayName, Azure.ResourceManager.AppService.VnetGatewayData connectionEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string gatewayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string gatewayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteVirtualNetworkConnectionGateway> Get(string gatewayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteVirtualNetworkConnectionGateway>> GetAsync(string gatewayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteVirtualNetworkConnectionGateway> GetIfExists(string gatewayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteVirtualNetworkConnectionGateway>> GetIfExistsAsync(string gatewayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteWebJob : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteWebJob() { }
        public virtual Azure.ResourceManager.AppService.WebJobData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string webJobName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteWebJob> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteWebJob>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteWebJobCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteWebJob>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteWebJob>, System.Collections.IEnumerable
    {
        protected SiteWebJobCollection() { }
        public virtual Azure.Response<bool> Exists(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteWebJob> Get(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteWebJob> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteWebJob> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteWebJob>> GetAsync(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteWebJob> GetIfExists(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteWebJob>> GetIfExistsAsync(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SiteWebJob> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SiteWebJob>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SiteWebJob> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SiteWebJob>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SlotConfigNamesResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SlotConfigNamesResource() { }
        public virtual Azure.ResourceManager.AppService.SlotConfigNamesResourceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SlotConfigNamesResource> CreateOrUpdate(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.SlotConfigNamesResourceData slotConfigNames, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SlotConfigNamesResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.SlotConfigNamesResourceData slotConfigNames, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SlotConfigNamesResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SlotConfigNamesResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SlotConfigNamesResourceData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public SlotConfigNamesResourceData() { }
        public System.Collections.Generic.IList<string> AppSettingNames { get { throw null; } }
        public System.Collections.Generic.IList<string> AzureStorageConfigNames { get { throw null; } }
        public System.Collections.Generic.IList<string> ConnectionStringNames { get { throw null; } }
    }
    public partial class SourceControl : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SourceControl() { }
        public virtual Azure.ResourceManager.AppService.SourceControlData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string sourceControlType) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SourceControl> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SourceControl>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SourceControlCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SourceControl>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SourceControl>, System.Collections.IEnumerable
    {
        protected SourceControlCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SourceControl> CreateOrUpdate(Azure.WaitUntil waitUntil, string sourceControlType, Azure.ResourceManager.AppService.SourceControlData requestMessage, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.SourceControl>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string sourceControlType, Azure.ResourceManager.AppService.SourceControlData requestMessage, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string sourceControlType, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string sourceControlType, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SourceControl> Get(string sourceControlType, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SourceControl> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SourceControl> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SourceControl>> GetAsync(string sourceControlType, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SourceControl> GetIfExists(string sourceControlType, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SourceControl>> GetIfExistsAsync(string sourceControlType, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.SourceControl> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.SourceControl>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.SourceControl> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.SourceControl>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SourceControlData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public SourceControlData() { }
        public System.DateTimeOffset? ExpirationTime { get { throw null; } set { } }
        public string RefreshToken { get { throw null; } set { } }
        public string Token { get { throw null; } set { } }
        public string TokenSecret { get { throw null; } set { } }
    }
    public partial class StaticSiteARMResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected StaticSiteARMResource() { }
        public virtual Azure.ResourceManager.AppService.StaticSiteARMResourceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.AppService.StaticSiteARMResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.StaticSiteARMResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.StringDictionary> CreateOrUpdateAppSettings(Azure.ResourceManager.AppService.Models.StringDictionary appSettings, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.StringDictionary>> CreateOrUpdateAppSettingsAsync(Azure.ResourceManager.AppService.Models.StringDictionary appSettings, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.StringDictionary> CreateOrUpdateFunctionAppSettings(Azure.ResourceManager.AppService.Models.StringDictionary appSettings, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.StringDictionary>> CreateOrUpdateFunctionAppSettingsAsync(Azure.ResourceManager.AppService.Models.StringDictionary appSettings, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.StaticSiteUserInvitationResponseResource> CreateUserRolesInvitationLink(Azure.ResourceManager.AppService.Models.StaticSiteUserInvitationRequestResource staticSiteUserRolesInvitationEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.StaticSiteUserInvitationResponseResource>> CreateUserRolesInvitationLinkAsync(Azure.ResourceManager.AppService.Models.StaticSiteUserInvitationRequestResource staticSiteUserRolesInvitationEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation CreateZipDeploymentForStaticSite(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.Models.StaticSiteZipDeploymentARMResource staticSiteZipDeploymentEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> CreateZipDeploymentForStaticSiteAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.Models.StaticSiteZipDeploymentARMResource staticSiteZipDeploymentEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DeleteUser(string authprovider, string userid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteUserAsync(string authprovider, string userid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Detach(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DetachAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.StaticSiteARMResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.StringDictionary> GetAppSettings(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.StringDictionary>> GetAppSettingsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.StaticSiteARMResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.StringList> GetConfiguredRoles(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.StringList>> GetConfiguredRolesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.StringDictionary> GetFunctionAppSettings(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.StringDictionary>> GetFunctionAppSettingsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.PrivateLinkResource> GetPrivateLinkResources(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.PrivateLinkResource> GetPrivateLinkResourcesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.StaticSiteBuildARMResource> GetStaticSiteBuildARMResource(string environmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.StaticSiteBuildARMResource>> GetStaticSiteBuildARMResourceAsync(string environmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.StaticSiteBuildARMResourceCollection GetStaticSiteBuildARMResources() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.StaticSiteCustomDomainOverviewARMResource> GetStaticSiteCustomDomainOverviewARMResource(string domainName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.StaticSiteCustomDomainOverviewARMResource>> GetStaticSiteCustomDomainOverviewARMResourceAsync(string domainName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.StaticSiteCustomDomainOverviewARMResourceCollection GetStaticSiteCustomDomainOverviewARMResources() { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.StaticSiteFunctionOverviewARMResource> GetStaticSiteFunctions(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.StaticSiteFunctionOverviewARMResource> GetStaticSiteFunctionsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.StaticSitePrivateEndpointConnection> GetStaticSitePrivateEndpointConnection(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.StaticSitePrivateEndpointConnection>> GetStaticSitePrivateEndpointConnectionAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.StaticSitePrivateEndpointConnectionCollection GetStaticSitePrivateEndpointConnections() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.StringDictionary> GetStaticSiteSecrets(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.StringDictionary>> GetStaticSiteSecretsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.StaticSiteUserProvidedFunctionApp> GetStaticSiteUserProvidedFunctionApp(string functionAppName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.StaticSiteUserProvidedFunctionApp>> GetStaticSiteUserProvidedFunctionAppAsync(string functionAppName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.StaticSiteUserProvidedFunctionAppCollection GetStaticSiteUserProvidedFunctionApps() { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.StaticSiteUserARMResource> GetUsers(string authprovider, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.StaticSiteUserARMResource> GetUsersAsync(string authprovider, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.StaticSiteARMResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.StaticSiteARMResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response ResetApiKey(Azure.ResourceManager.AppService.Models.StaticSiteResetPropertiesARMResource resetPropertiesEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> ResetApiKeyAsync(Azure.ResourceManager.AppService.Models.StaticSiteResetPropertiesARMResource resetPropertiesEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.StaticSiteARMResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.StaticSiteARMResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.StaticSiteARMResource> Update(Azure.ResourceManager.AppService.Models.PatchableStaticSiteARMResourceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.StaticSiteARMResource>> UpdateAsync(Azure.ResourceManager.AppService.Models.PatchableStaticSiteARMResourceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.StaticSiteUserARMResource> UpdateUser(string authprovider, string userid, Azure.ResourceManager.AppService.Models.StaticSiteUserARMResource staticSiteUserEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.StaticSiteUserARMResource>> UpdateUserAsync(string authprovider, string userid, Azure.ResourceManager.AppService.Models.StaticSiteUserARMResource staticSiteUserEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class StaticSiteARMResourceCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.StaticSiteARMResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.StaticSiteARMResource>, System.Collections.IEnumerable
    {
        protected StaticSiteARMResourceCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.StaticSiteARMResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string name, Azure.ResourceManager.AppService.StaticSiteARMResourceData staticSiteEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.StaticSiteARMResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string name, Azure.ResourceManager.AppService.StaticSiteARMResourceData staticSiteEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.StaticSiteARMResource> Get(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.StaticSiteARMResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.StaticSiteARMResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.StaticSiteARMResource>> GetAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.StaticSiteARMResource> GetIfExists(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.StaticSiteARMResource>> GetIfExistsAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.StaticSiteARMResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.StaticSiteARMResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.StaticSiteARMResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.StaticSiteARMResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class StaticSiteARMResourceData : Azure.ResourceManager.AppService.Models.AppServiceResource
    {
        public StaticSiteARMResourceData(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public bool? AllowConfigFileUpdates { get { throw null; } set { } }
        public string Branch { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.StaticSiteBuildProperties BuildProperties { get { throw null; } set { } }
        public string ContentDistributionEndpoint { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> CustomDomains { get { throw null; } }
        public string DefaultHostname { get { throw null; } }
        public Azure.ResourceManager.Models.ManagedServiceIdentity Identity { get { throw null; } set { } }
        public string KeyVaultReferenceIdentity { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppService.Models.ResponseMessageEnvelopeRemotePrivateEndpointConnection> PrivateEndpointConnections { get { throw null; } }
        public string Provider { get { throw null; } }
        public string RepositoryToken { get { throw null; } set { } }
        public string RepositoryUrl { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.SkuDescription Sku { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.StagingEnvironmentPolicy? StagingEnvironmentPolicy { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.StaticSiteTemplateOptions TemplateProperties { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppService.Models.StaticSiteUserProvidedFunctionApp> UserProvidedFunctionApps { get { throw null; } }
    }
    public partial class StaticSiteBuildARMResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected StaticSiteBuildARMResource() { }
        public virtual Azure.ResourceManager.AppService.StaticSiteBuildARMResourceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.StringDictionary> CreateOrUpdateStaticSiteBuildAppSettings(Azure.ResourceManager.AppService.Models.StringDictionary appSettings, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.StringDictionary>> CreateOrUpdateStaticSiteBuildAppSettingsAsync(Azure.ResourceManager.AppService.Models.StringDictionary appSettings, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.StringDictionary> CreateOrUpdateStaticSiteBuildFunctionAppSettings(Azure.ResourceManager.AppService.Models.StringDictionary appSettings, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.StringDictionary>> CreateOrUpdateStaticSiteBuildFunctionAppSettingsAsync(Azure.ResourceManager.AppService.Models.StringDictionary appSettings, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string environmentName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation CreateZipDeploymentForStaticSiteBuild(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.Models.StaticSiteZipDeploymentARMResource staticSiteZipDeploymentEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> CreateZipDeploymentForStaticSiteBuildAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.Models.StaticSiteZipDeploymentARMResource staticSiteZipDeploymentEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.StaticSiteBuildARMResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.StaticSiteBuildARMResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.StringDictionary> GetStaticSiteBuildAppSettings(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.StringDictionary>> GetStaticSiteBuildAppSettingsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.StringDictionary> GetStaticSiteBuildFunctionAppSettings(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.StringDictionary>> GetStaticSiteBuildFunctionAppSettingsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.StaticSiteFunctionOverviewARMResource> GetStaticSiteBuildFunctions(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.StaticSiteFunctionOverviewARMResource> GetStaticSiteBuildFunctionsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.StaticSiteBuildUserProvidedFunctionApp> GetStaticSiteBuildUserProvidedFunctionApp(string functionAppName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.StaticSiteBuildUserProvidedFunctionApp>> GetStaticSiteBuildUserProvidedFunctionAppAsync(string functionAppName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.StaticSiteBuildUserProvidedFunctionAppCollection GetStaticSiteBuildUserProvidedFunctionApps() { throw null; }
    }
    public partial class StaticSiteBuildARMResourceCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.StaticSiteBuildARMResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.StaticSiteBuildARMResource>, System.Collections.IEnumerable
    {
        protected StaticSiteBuildARMResourceCollection() { }
        public virtual Azure.Response<bool> Exists(string environmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string environmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.StaticSiteBuildARMResource> Get(string environmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.StaticSiteBuildARMResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.StaticSiteBuildARMResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.StaticSiteBuildARMResource>> GetAsync(string environmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.StaticSiteBuildARMResource> GetIfExists(string environmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.StaticSiteBuildARMResource>> GetIfExistsAsync(string environmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.StaticSiteBuildARMResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.StaticSiteBuildARMResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.StaticSiteBuildARMResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.StaticSiteBuildARMResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class StaticSiteBuildARMResourceData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public StaticSiteBuildARMResourceData() { }
        public string BuildId { get { throw null; } }
        public System.DateTimeOffset? CreatedTimeUtc { get { throw null; } }
        public string Hostname { get { throw null; } }
        public System.DateTimeOffset? LastUpdatedOn { get { throw null; } }
        public string PullRequestTitle { get { throw null; } }
        public string SourceBranch { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.BuildStatus? Status { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppService.Models.StaticSiteUserProvidedFunctionApp> UserProvidedFunctionApps { get { throw null; } }
    }
    public partial class StaticSiteBuildUserProvidedFunctionApp : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected StaticSiteBuildUserProvidedFunctionApp() { }
        public virtual Azure.ResourceManager.AppService.StaticSiteUserProvidedFunctionAppARMResourceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string environmentName, string functionAppName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.StaticSiteBuildUserProvidedFunctionApp> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.StaticSiteBuildUserProvidedFunctionApp>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class StaticSiteBuildUserProvidedFunctionAppCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.StaticSiteBuildUserProvidedFunctionApp>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.StaticSiteBuildUserProvidedFunctionApp>, System.Collections.IEnumerable
    {
        protected StaticSiteBuildUserProvidedFunctionAppCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.StaticSiteBuildUserProvidedFunctionApp> CreateOrUpdate(Azure.WaitUntil waitUntil, string functionAppName, Azure.ResourceManager.AppService.StaticSiteUserProvidedFunctionAppARMResourceData staticSiteUserProvidedFunctionEnvelope, bool? isForced = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.StaticSiteBuildUserProvidedFunctionApp>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string functionAppName, Azure.ResourceManager.AppService.StaticSiteUserProvidedFunctionAppARMResourceData staticSiteUserProvidedFunctionEnvelope, bool? isForced = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string functionAppName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string functionAppName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.StaticSiteBuildUserProvidedFunctionApp> Get(string functionAppName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.StaticSiteBuildUserProvidedFunctionApp> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.StaticSiteBuildUserProvidedFunctionApp> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.StaticSiteBuildUserProvidedFunctionApp>> GetAsync(string functionAppName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.StaticSiteBuildUserProvidedFunctionApp> GetIfExists(string functionAppName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.StaticSiteBuildUserProvidedFunctionApp>> GetIfExistsAsync(string functionAppName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.StaticSiteBuildUserProvidedFunctionApp> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.StaticSiteBuildUserProvidedFunctionApp>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.StaticSiteBuildUserProvidedFunctionApp> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.StaticSiteBuildUserProvidedFunctionApp>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class StaticSiteCustomDomainOverviewARMResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected StaticSiteCustomDomainOverviewARMResource() { }
        public virtual Azure.ResourceManager.AppService.StaticSiteCustomDomainOverviewARMResourceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string domainName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.StaticSiteCustomDomainOverviewARMResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.StaticSiteCustomDomainOverviewARMResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation ValidateCustomDomainCanBeAddedToStaticSite(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.Models.StaticSiteCustomDomainRequestPropertiesARMResource staticSiteCustomDomainRequestPropertiesEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> ValidateCustomDomainCanBeAddedToStaticSiteAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.Models.StaticSiteCustomDomainRequestPropertiesARMResource staticSiteCustomDomainRequestPropertiesEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class StaticSiteCustomDomainOverviewARMResourceCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.StaticSiteCustomDomainOverviewARMResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.StaticSiteCustomDomainOverviewARMResource>, System.Collections.IEnumerable
    {
        protected StaticSiteCustomDomainOverviewARMResourceCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.StaticSiteCustomDomainOverviewARMResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string domainName, Azure.ResourceManager.AppService.Models.StaticSiteCustomDomainRequestPropertiesARMResource staticSiteCustomDomainRequestPropertiesEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.StaticSiteCustomDomainOverviewARMResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string domainName, Azure.ResourceManager.AppService.Models.StaticSiteCustomDomainRequestPropertiesARMResource staticSiteCustomDomainRequestPropertiesEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string domainName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string domainName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.StaticSiteCustomDomainOverviewARMResource> Get(string domainName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.StaticSiteCustomDomainOverviewARMResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.StaticSiteCustomDomainOverviewARMResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.StaticSiteCustomDomainOverviewARMResource>> GetAsync(string domainName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.StaticSiteCustomDomainOverviewARMResource> GetIfExists(string domainName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.StaticSiteCustomDomainOverviewARMResource>> GetIfExistsAsync(string domainName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.StaticSiteCustomDomainOverviewARMResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.StaticSiteCustomDomainOverviewARMResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.StaticSiteCustomDomainOverviewARMResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.StaticSiteCustomDomainOverviewARMResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class StaticSiteCustomDomainOverviewARMResourceData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public StaticSiteCustomDomainOverviewARMResourceData() { }
        public System.DateTimeOffset? CreatedOn { get { throw null; } }
        public string DomainName { get { throw null; } }
        public string ErrorMessage { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.CustomDomainStatus? Status { get { throw null; } }
        public string ValidationToken { get { throw null; } }
    }
    public partial class StaticSitePrivateEndpointConnection : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected StaticSitePrivateEndpointConnection() { }
        public virtual Azure.ResourceManager.AppService.RemotePrivateEndpointConnectionARMResourceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string privateEndpointConnectionName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<System.BinaryData> Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<System.BinaryData>> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.StaticSitePrivateEndpointConnection> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.StaticSitePrivateEndpointConnection>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class StaticSitePrivateEndpointConnectionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.StaticSitePrivateEndpointConnection>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.StaticSitePrivateEndpointConnection>, System.Collections.IEnumerable
    {
        protected StaticSitePrivateEndpointConnectionCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.StaticSitePrivateEndpointConnection> CreateOrUpdate(Azure.WaitUntil waitUntil, string privateEndpointConnectionName, Azure.ResourceManager.AppService.Models.PrivateLinkConnectionApprovalRequestResource privateEndpointWrapper, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.StaticSitePrivateEndpointConnection>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string privateEndpointConnectionName, Azure.ResourceManager.AppService.Models.PrivateLinkConnectionApprovalRequestResource privateEndpointWrapper, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.StaticSitePrivateEndpointConnection> Get(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.StaticSitePrivateEndpointConnection> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.StaticSitePrivateEndpointConnection> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.StaticSitePrivateEndpointConnection>> GetAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.StaticSitePrivateEndpointConnection> GetIfExists(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.StaticSitePrivateEndpointConnection>> GetIfExistsAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.StaticSitePrivateEndpointConnection> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.StaticSitePrivateEndpointConnection>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.StaticSitePrivateEndpointConnection> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.StaticSitePrivateEndpointConnection>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class StaticSiteUserProvidedFunctionApp : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected StaticSiteUserProvidedFunctionApp() { }
        public virtual Azure.ResourceManager.AppService.StaticSiteUserProvidedFunctionAppARMResourceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string functionAppName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.StaticSiteUserProvidedFunctionApp> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.StaticSiteUserProvidedFunctionApp>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class StaticSiteUserProvidedFunctionAppARMResourceData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public StaticSiteUserProvidedFunctionAppARMResourceData() { }
        public System.DateTimeOffset? CreatedOn { get { throw null; } }
        public string FunctionAppRegion { get { throw null; } set { } }
        public string FunctionAppResourceId { get { throw null; } set { } }
    }
    public partial class StaticSiteUserProvidedFunctionAppCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.StaticSiteUserProvidedFunctionApp>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.StaticSiteUserProvidedFunctionApp>, System.Collections.IEnumerable
    {
        protected StaticSiteUserProvidedFunctionAppCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.StaticSiteUserProvidedFunctionApp> CreateOrUpdate(Azure.WaitUntil waitUntil, string functionAppName, Azure.ResourceManager.AppService.StaticSiteUserProvidedFunctionAppARMResourceData staticSiteUserProvidedFunctionEnvelope, bool? isForced = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.StaticSiteUserProvidedFunctionApp>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string functionAppName, Azure.ResourceManager.AppService.StaticSiteUserProvidedFunctionAppARMResourceData staticSiteUserProvidedFunctionEnvelope, bool? isForced = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string functionAppName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string functionAppName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.StaticSiteUserProvidedFunctionApp> Get(string functionAppName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.StaticSiteUserProvidedFunctionApp> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.StaticSiteUserProvidedFunctionApp> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.StaticSiteUserProvidedFunctionApp>> GetAsync(string functionAppName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.StaticSiteUserProvidedFunctionApp> GetIfExists(string functionAppName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.StaticSiteUserProvidedFunctionApp>> GetIfExistsAsync(string functionAppName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.StaticSiteUserProvidedFunctionApp> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.StaticSiteUserProvidedFunctionApp>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.StaticSiteUserProvidedFunctionApp> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.StaticSiteUserProvidedFunctionApp>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SwiftVirtualNetworkData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public SwiftVirtualNetworkData() { }
        public string SubnetResourceId { get { throw null; } set { } }
        public bool? SwiftSupported { get { throw null; } set { } }
    }
    public partial class TopLevelDomain : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected TopLevelDomain() { }
        public virtual Azure.ResourceManager.AppService.TopLevelDomainData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string name) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.TopLevelDomain> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.TldLegalAgreement> GetAgreements(Azure.ResourceManager.AppService.Models.TopLevelDomainAgreementOption agreementOption, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.TldLegalAgreement> GetAgreementsAsync(Azure.ResourceManager.AppService.Models.TopLevelDomainAgreementOption agreementOption, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.TopLevelDomain>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class TopLevelDomainCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.TopLevelDomain>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.TopLevelDomain>, System.Collections.IEnumerable
    {
        protected TopLevelDomainCollection() { }
        public virtual Azure.Response<bool> Exists(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.TopLevelDomain> Get(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.TopLevelDomain> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.TopLevelDomain> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.TopLevelDomain>> GetAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.TopLevelDomain> GetIfExists(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.TopLevelDomain>> GetIfExistsAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.TopLevelDomain> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.TopLevelDomain>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.TopLevelDomain> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.TopLevelDomain>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class TopLevelDomainData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public TopLevelDomainData() { }
        public bool? Privacy { get { throw null; } set { } }
    }
    public partial class TriggeredJobHistoryData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public TriggeredJobHistoryData() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.TriggeredJobRun> Runs { get { throw null; } }
    }
    public partial class TriggeredWebJobData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public TriggeredWebJobData() { }
        public string Error { get { throw null; } set { } }
        public string ExtraInfoUrl { get { throw null; } set { } }
        public string HistoryUrl { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.TriggeredJobRun LatestRun { get { throw null; } set { } }
        public string RunCommand { get { throw null; } set { } }
        public string SchedulerLogsUrl { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, System.BinaryData> Settings { get { throw null; } }
        public string Url { get { throw null; } set { } }
        public bool? UsingSdk { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.WebJobType? WebJobType { get { throw null; } set { } }
    }
    public partial class User : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected User() { }
        public virtual Azure.ResourceManager.AppService.UserData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.User> CreateOrUpdate(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.UserData userDetails, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.User>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.UserData userDetails, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.User> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.User>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class UserData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public UserData() { }
        public string PublishingPassword { get { throw null; } set { } }
        public string PublishingPasswordHash { get { throw null; } set { } }
        public string PublishingPasswordHashSalt { get { throw null; } set { } }
        public string PublishingUserName { get { throw null; } set { } }
        public System.Uri ScmUri { get { throw null; } set { } }
    }
    public partial class VnetGatewayData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public VnetGatewayData() { }
        public string VnetName { get { throw null; } set { } }
        public System.Uri VpnPackageUri { get { throw null; } set { } }
    }
    public partial class VnetInfoResourceData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public VnetInfoResourceData() { }
        public string CertBlob { get { throw null; } set { } }
        public string CertThumbprint { get { throw null; } }
        public string DnsServers { get { throw null; } set { } }
        public bool? IsSwift { get { throw null; } set { } }
        public bool? ResyncRequired { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppService.Models.VnetRoute> Routes { get { throw null; } }
        public string VnetResourceId { get { throw null; } set { } }
    }
    public partial class WebJobData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public WebJobData() { }
        public string Error { get { throw null; } set { } }
        public string ExtraInfoUrl { get { throw null; } set { } }
        public string RunCommand { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, System.BinaryData> Settings { get { throw null; } }
        public string Url { get { throw null; } set { } }
        public bool? UsingSdk { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.WebJobType? WebJobType { get { throw null; } set { } }
    }
    public partial class WebSite : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected WebSite() { }
        public virtual Azure.ResourceManager.AppService.WebSiteData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.AppService.WebSite> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.WebSite>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.CustomHostnameAnalysisResult> AnalyzeCustomHostname(string hostName = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.CustomHostnameAnalysisResult>> AnalyzeCustomHostnameAsync(string hostName = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response ApplySlotConfigToProduction(Azure.ResourceManager.AppService.Models.CsmSlotEntity slotSwapEntity, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> ApplySlotConfigToProductionAsync(Azure.ResourceManager.AppService.Models.CsmSlotEntity slotSwapEntity, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteBackup> Backup(Azure.ResourceManager.AppService.Models.BackupRequest request, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteBackup>> BackupAsync(Azure.ResourceManager.AppService.Models.BackupRequest request, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.KeyInfo> CreateOrUpdateHostSecret(string keyType, string keyName, Azure.ResourceManager.AppService.Models.KeyInfo key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.KeyInfo>> CreateOrUpdateHostSecretAsync(string keyType, string keyName, Azure.ResourceManager.AppService.Models.KeyInfo key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, bool? deleteMetrics = default(bool?), bool? deleteEmptyServerFarm = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, bool? deleteMetrics = default(bool?), bool? deleteEmptyServerFarm = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DeleteBackupConfiguration(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteBackupConfigurationAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DeleteHostSecret(string keyType, string keyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteHostSecretAsync(string keyType, string keyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DisableAllForWebAppRecommendation(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DisableAllForWebAppRecommendationAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.RestoreRequest> DiscoverBackup(Azure.ResourceManager.AppService.Models.RestoreRequest request, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.RestoreRequest>> DiscoverBackupAsync(Azure.ResourceManager.AppService.Models.RestoreRequest request, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GenerateNewSitePublishingPassword(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GenerateNewSitePublishingPasswordAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.WebSite> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.StringDictionary> GetApplicationSettings(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.StringDictionary>> GetApplicationSettingsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.WebSite>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.SiteAuthSettings> GetAuthSettings(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.SiteAuthSettings>> GetAuthSettingsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.SiteAuthSettingsV2> GetAuthSettingsV2(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.SiteAuthSettingsV2>> GetAuthSettingsV2Async(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.AzureStoragePropertyDictionaryResource> GetAzureStorageAccounts(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.AzureStoragePropertyDictionaryResource>> GetAzureStorageAccountsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.BackupRequest> GetBackupConfiguration(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.BackupRequest>> GetBackupConfigurationAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.BasicPublishingCredentialsPolicyFtp GetBasicPublishingCredentialsPolicyFtp() { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.WebSiteConfig> GetConfigurations(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.WebSiteConfig> GetConfigurationsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.ConnectionStringDictionary> GetConnectionStrings(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.ConnectionStringDictionary>> GetConnectionStringsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<System.IO.Stream> GetContainerLogsZip(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.IO.Stream>> GetContainerLogsZipAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<string> GetFunctionsAdminToken(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<string>> GetFunctionsAdminTokenAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.AppServiceRecommendation> GetHistoryForWebAppRecommendations(bool? expiredOnly = default(bool?), string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.AppServiceRecommendation> GetHistoryForWebAppRecommendationsAsync(bool? expiredOnly = default(bool?), string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.HostKeys> GetHostKeys(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.HostKeys>> GetHostKeysAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.ServerfarmHybridConnectionNamespaceRelay> GetHybridConnections(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.ServerfarmHybridConnectionNamespaceRelay>> GetHybridConnectionsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.LogsSiteConfig GetLogsSiteConfig() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.StringDictionary> GetMetadata(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.StringDictionary>> GetMetadataAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.MigrateMySqlStatus> GetMigrateMySqlStatus(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.MigrateMySqlStatus>> GetMigrateMySqlStatusAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.NetworkFeatures> GetNetworkFeatures(string view, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.NetworkFeatures>> GetNetworkFeaturesAsync(string view, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.NetworkTrace> GetNetworkTraceOperation(string operationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.NetworkTrace> GetNetworkTraceOperationAsync(string operationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.NetworkTrace> GetNetworkTraceOperationV2(string operationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.NetworkTrace> GetNetworkTraceOperationV2Async(string operationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.NetworkTrace> GetNetworkTraces(string operationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.NetworkTrace> GetNetworkTracesAsync(string operationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.NetworkTrace> GetNetworkTracesV2(string operationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.NetworkTrace> GetNetworkTracesV2Async(string operationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.PerfMonResponse> GetPerfMonCounters(string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.PerfMonResponse> GetPerfMonCountersAsync(string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SitePremierAddon> GetPremierAddOns(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SitePremierAddon>> GetPremierAddOnsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.PrivateLinkResource> GetPrivateLinkResources(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.PrivateLinkResource> GetPrivateLinkResourcesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.User> GetPublishingCredentials(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.User>> GetPublishingCredentialsAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<System.IO.Stream> GetPublishingProfileXmlWithSecrets(Azure.ResourceManager.AppService.Models.CsmPublishingProfileOptions publishingProfileOptions, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.IO.Stream>> GetPublishingProfileXmlWithSecretsAsync(Azure.ResourceManager.AppService.Models.CsmPublishingProfileOptions publishingProfileOptions, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.AppServiceRecommendation> GetRecommendedRulesForWebAppRecommendations(bool? featured = default(bool?), string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.AppServiceRecommendation> GetRecommendedRulesForWebAppRecommendationsAsync(bool? featured = default(bool?), string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteHybridConnection> GetRelayServiceConnections(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteHybridConnection>> GetRelayServiceConnectionsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.ScmSiteBasicPublishingCredentialsPolicy GetScmSiteBasicPublishingCredentialsPolicy() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteBackup> GetSiteBackup(string backupId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteBackup>> GetSiteBackupAsync(string backupId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteBackupCollection GetSiteBackups() { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.SiteBackup> GetSiteBackups(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.SiteBackup> GetSiteBackupsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteConfigAppsetting> GetSiteConfigAppsetting(string appSettingKey, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteConfigAppsetting>> GetSiteConfigAppsettingAsync(string appSettingKey, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteConfigAppsettingCollection GetSiteConfigAppsettings() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteConfigConnectionString> GetSiteConfigConnectionString(string connectionStringKey, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteConfigConnectionString>> GetSiteConfigConnectionStringAsync(string connectionStringKey, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteConfigConnectionStringCollection GetSiteConfigConnectionStrings() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteContinuousWebJob> GetSiteContinuousWebJob(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteContinuousWebJob>> GetSiteContinuousWebJobAsync(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteContinuousWebJobCollection GetSiteContinuousWebJobs() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteDeployment> GetSiteDeployment(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteDeployment>> GetSiteDeploymentAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteDeploymentCollection GetSiteDeployments() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteDetector> GetSiteDetector(string detectorName, System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteDetector>> GetSiteDetectorAsync(string detectorName, System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string timeGrain = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteDetectorCollection GetSiteDetectors() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteDiagnostic> GetSiteDiagnostic(string diagnosticCategory, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteDiagnostic>> GetSiteDiagnosticAsync(string diagnosticCategory, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteDiagnosticCollection GetSiteDiagnostics() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteDomainOwnershipIdentifier> GetSiteDomainOwnershipIdentifier(string domainOwnershipIdentifierName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteDomainOwnershipIdentifier>> GetSiteDomainOwnershipIdentifierAsync(string domainOwnershipIdentifierName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteDomainOwnershipIdentifierCollection GetSiteDomainOwnershipIdentifiers() { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteExtension GetSiteExtension() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteFunction> GetSiteFunction(string functionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteFunction>> GetSiteFunctionAsync(string functionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteFunctionCollection GetSiteFunctions() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteHostNameBinding> GetSiteHostNameBinding(string hostName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteHostNameBinding>> GetSiteHostNameBindingAsync(string hostName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteHostNameBindingCollection GetSiteHostNameBindings() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteHybridConnection> GetSiteHybridConnection(string entityName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteHybridConnection>> GetSiteHybridConnectionAsync(string entityName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteHybridConnectionNamespaceRelay> GetSiteHybridConnectionNamespaceRelay(string namespaceName, string relayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteHybridConnectionNamespaceRelay>> GetSiteHybridConnectionNamespaceRelayAsync(string namespaceName, string relayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteHybridConnectionNamespaceRelayCollection GetSiteHybridConnectionNamespaceRelays() { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteHybridConnectionCollection GetSiteHybridConnections() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteInstance> GetSiteInstance(string instanceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteInstance>> GetSiteInstanceAsync(string instanceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteInstanceCollection GetSiteInstances() { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteNetworkConfig GetSiteNetworkConfig() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.SitePhpErrorLogFlag> GetSitePhpErrorLogFlag(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.SitePhpErrorLogFlag>> GetSitePhpErrorLogFlagAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SitePremierAddon> GetSitePremierAddon(string premierAddOnName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SitePremierAddon>> GetSitePremierAddonAsync(string premierAddOnName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SitePremierAddonCollection GetSitePremierAddons() { throw null; }
        public virtual Azure.ResourceManager.AppService.SitePrivateAccess GetSitePrivateAccess() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SitePrivateEndpointConnection> GetSitePrivateEndpointConnection(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SitePrivateEndpointConnection>> GetSitePrivateEndpointConnectionAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SitePrivateEndpointConnectionCollection GetSitePrivateEndpointConnections() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteProcess> GetSiteProcess(string processId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteProcess>> GetSiteProcessAsync(string processId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteProcessCollection GetSiteProcesses() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SitePublicCertificate> GetSitePublicCertificate(string publicCertificateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SitePublicCertificate>> GetSitePublicCertificateAsync(string publicCertificateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SitePublicCertificateCollection GetSitePublicCertificates() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.PushSettings> GetSitePushSettings(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.PushSettings>> GetSitePushSettingsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteRecommendation> GetSiteRecommendation(string name, bool? updateSeen = default(bool?), string recommendationId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteRecommendation>> GetSiteRecommendationAsync(string name, bool? updateSeen = default(bool?), string recommendationId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteRecommendationCollection GetSiteRecommendations() { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteResourceHealthMetadata GetSiteResourceHealthMetadata() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSiteextension> GetSiteSiteextension(string siteExtensionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSiteextension>> GetSiteSiteextensionAsync(string siteExtensionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteSiteextensionCollection GetSiteSiteextensions() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlot> GetSiteSlot(string slot, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlot>> GetSiteSlotAsync(string slot, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteSlotCollection GetSiteSlots() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotTriggeredWebJob> GetSiteSlotTriggeredWebJob(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotTriggeredWebJob>> GetSiteSlotTriggeredWebJobAsync(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteSlotTriggeredWebJobCollection GetSiteSlotTriggeredWebJobs() { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteSourceControl GetSiteSourceControl() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteVirtualNetworkConnection> GetSiteVirtualNetworkConnection(string vnetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteVirtualNetworkConnection>> GetSiteVirtualNetworkConnectionAsync(string vnetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteVirtualNetworkConnectionCollection GetSiteVirtualNetworkConnections() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteWebJob> GetSiteWebJob(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteWebJob>> GetSiteWebJobAsync(string webJobName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteWebJobCollection GetSiteWebJobs() { throw null; }
        public virtual Azure.ResourceManager.AppService.SlotConfigNamesResource GetSlotConfigNamesResource() { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.SlotDifference> GetSlotDifferencesFromProduction(Azure.ResourceManager.AppService.Models.CsmSlotEntity slotSwapEntity, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.SlotDifference> GetSlotDifferencesFromProductionAsync(Azure.ResourceManager.AppService.Models.CsmSlotEntity slotSwapEntity, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.Snapshot> GetSnapshots(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.Snapshot> GetSnapshotsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.Snapshot> GetSnapshotsFromDRSecondary(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.Snapshot> GetSnapshotsFromDRSecondaryAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.FunctionSecrets> GetSyncFunctionTriggers(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.FunctionSecrets>> GetSyncFunctionTriggersAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetSyncStatus(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetSyncStatusAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.CsmUsageQuota> GetUsages(string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.CsmUsageQuota> GetUsagesAsync(string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.WebSiteConfig GetWebSiteConfig() { throw null; }
        public virtual Azure.Response<System.IO.Stream> GetWebSiteContainerLogs(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.IO.Stream>> GetWebSiteContainerLogsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.SiteCloneability> IsCloneable(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.SiteCloneability>> IsCloneableAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.Models.OperationInformation> MigrateMySql(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.Models.MigrateMySqlRequest migrationRequestEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.Models.OperationInformation>> MigrateMySqlAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.Models.MigrateMySqlRequest migrationRequestEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.Models.StorageMigrationResponse> MigrateStorage(Azure.WaitUntil waitUntil, string subscriptionName, Azure.ResourceManager.AppService.Models.StorageMigrationOptions migrationOptions, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.Models.StorageMigrationResponse>> MigrateStorageAsync(Azure.WaitUntil waitUntil, string subscriptionName, Azure.ResourceManager.AppService.Models.StorageMigrationOptions migrationOptions, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.WebSite> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.WebSite>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response ResetAllFiltersForWebAppRecommendation(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> ResetAllFiltersForWebAppRecommendationAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response ResetProductionSlotConfig(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> ResetProductionSlotConfigAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response Restart(bool? softRestart = default(bool?), bool? synchronous = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> RestartAsync(bool? softRestart = default(bool?), bool? synchronous = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation RestoreFromBackupBlob(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.Models.RestoreRequest request, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> RestoreFromBackupBlobAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.Models.RestoreRequest request, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation RestoreFromDeletedApp(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.Models.DeletedAppRestoreRequest restoreRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> RestoreFromDeletedAppAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.Models.DeletedAppRestoreRequest restoreRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation RestoreSnapshot(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.Models.SnapshotRestoreRequest restoreRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> RestoreSnapshotAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.Models.SnapshotRestoreRequest restoreRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.WebSite> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.WebSite>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response Start(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> StartAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.NetworkTrace>> StartNetworkTrace(Azure.WaitUntil waitUntil, int? durationInSeconds = default(int?), int? maxFrameLength = default(int?), string sasUrl = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.NetworkTrace>>> StartNetworkTraceAsync(Azure.WaitUntil waitUntil, int? durationInSeconds = default(int?), int? maxFrameLength = default(int?), string sasUrl = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<string> StartWebSiteNetworkTrace(int? durationInSeconds = default(int?), int? maxFrameLength = default(int?), string sasUrl = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<string>> StartWebSiteNetworkTraceAsync(int? durationInSeconds = default(int?), int? maxFrameLength = default(int?), string sasUrl = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.NetworkTrace>> StartWebSiteNetworkTraceOperation(Azure.WaitUntil waitUntil, int? durationInSeconds = default(int?), int? maxFrameLength = default(int?), string sasUrl = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.NetworkTrace>>> StartWebSiteNetworkTraceOperationAsync(Azure.WaitUntil waitUntil, int? durationInSeconds = default(int?), int? maxFrameLength = default(int?), string sasUrl = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response Stop(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> StopAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response StopNetworkTrace(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> StopNetworkTraceAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response StopWebSiteNetworkTrace(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> StopWebSiteNetworkTraceAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation SwapSlotWithProduction(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.Models.CsmSlotEntity slotSwapEntity, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> SwapSlotWithProductionAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.Models.CsmSlotEntity slotSwapEntity, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response SyncFunctions(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> SyncFunctionsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response SyncFunctionTriggers(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> SyncFunctionTriggersAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response SyncRepository(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> SyncRepositoryAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.WebSite> Update(Azure.ResourceManager.AppService.Models.SitePatchResource siteEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.StringDictionary> UpdateApplicationSettings(Azure.ResourceManager.AppService.Models.StringDictionary appSettings, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.StringDictionary>> UpdateApplicationSettingsAsync(Azure.ResourceManager.AppService.Models.StringDictionary appSettings, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.WebSite>> UpdateAsync(Azure.ResourceManager.AppService.Models.SitePatchResource siteEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.SiteAuthSettings> UpdateAuthSettings(Azure.ResourceManager.AppService.Models.SiteAuthSettings siteAuthSettings, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.SiteAuthSettings>> UpdateAuthSettingsAsync(Azure.ResourceManager.AppService.Models.SiteAuthSettings siteAuthSettings, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.SiteAuthSettingsV2> UpdateAuthSettingsV2(Azure.ResourceManager.AppService.Models.SiteAuthSettingsV2 siteAuthSettingsV2, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.SiteAuthSettingsV2>> UpdateAuthSettingsV2Async(Azure.ResourceManager.AppService.Models.SiteAuthSettingsV2 siteAuthSettingsV2, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.AzureStoragePropertyDictionaryResource> UpdateAzureStorageAccounts(Azure.ResourceManager.AppService.Models.AzureStoragePropertyDictionaryResource azureStorageAccounts, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.AzureStoragePropertyDictionaryResource>> UpdateAzureStorageAccountsAsync(Azure.ResourceManager.AppService.Models.AzureStoragePropertyDictionaryResource azureStorageAccounts, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.BackupRequest> UpdateBackupConfiguration(Azure.ResourceManager.AppService.Models.BackupRequest request, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.BackupRequest>> UpdateBackupConfigurationAsync(Azure.ResourceManager.AppService.Models.BackupRequest request, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.ConnectionStringDictionary> UpdateConnectionStrings(Azure.ResourceManager.AppService.Models.ConnectionStringDictionary connectionStrings, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.ConnectionStringDictionary>> UpdateConnectionStringsAsync(Azure.ResourceManager.AppService.Models.ConnectionStringDictionary connectionStrings, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.StringDictionary> UpdateMetadata(Azure.ResourceManager.AppService.Models.StringDictionary metadata, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.StringDictionary>> UpdateMetadataAsync(Azure.ResourceManager.AppService.Models.StringDictionary metadata, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.Models.PushSettings> UpdateSitePushSettings(Azure.ResourceManager.AppService.Models.PushSettings pushSettings, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.Models.PushSettings>> UpdateSitePushSettingsAsync(Azure.ResourceManager.AppService.Models.PushSettings pushSettings, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class WebSiteCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.WebSite>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.WebSite>, System.Collections.IEnumerable
    {
        protected WebSiteCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.WebSite> CreateOrUpdate(Azure.WaitUntil waitUntil, string name, Azure.ResourceManager.AppService.WebSiteData siteEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.WebSite>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string name, Azure.ResourceManager.AppService.WebSiteData siteEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.WebSite> Get(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.WebSite> GetAll(bool? includeSlots = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.WebSite> GetAllAsync(bool? includeSlots = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.WebSite>> GetAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.WebSite> GetIfExists(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.WebSite>> GetIfExistsAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppService.WebSite> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppService.WebSite>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppService.WebSite> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppService.WebSite>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class WebSiteConfig : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected WebSiteConfig() { }
        public virtual Azure.ResourceManager.AppService.SiteConfigData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.WebSiteConfig> CreateOrUpdate(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.SiteConfigData siteConfig, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.WebSiteConfig>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.SiteConfigData siteConfig, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.WebSiteConfig> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.WebSiteConfig>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.SiteConfigurationSnapshotInfo> GetConfigurationSnapshotInfo(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.SiteConfigurationSnapshotInfo> GetConfigurationSnapshotInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteConfigSnapshot> GetSiteConfigSnapshot(string snapshotId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteConfigSnapshot>> GetSiteConfigSnapshotAsync(string snapshotId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteConfigSnapshotCollection GetSiteConfigSnapshots() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.WebSiteConfig> Update(Azure.ResourceManager.AppService.SiteConfigData siteConfig, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.WebSiteConfig>> UpdateAsync(Azure.ResourceManager.AppService.SiteConfigData siteConfig, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class WebSiteData : Azure.ResourceManager.AppService.Models.AppServiceResource
    {
        public WebSiteData(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public Azure.ResourceManager.AppService.Models.SiteAvailabilityState? AvailabilityState { get { throw null; } }
        public bool? ClientAffinityEnabled { get { throw null; } set { } }
        public bool? ClientCertEnabled { get { throw null; } set { } }
        public string ClientCertExclusionPaths { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.ClientCertMode? ClientCertMode { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.CloningInfo CloningInfo { get { throw null; } set { } }
        public int? ContainerSize { get { throw null; } set { } }
        public string CustomDomainVerificationId { get { throw null; } set { } }
        public int? DailyMemoryTimeQuota { get { throw null; } set { } }
        public string DefaultHostName { get { throw null; } }
        public bool? Enabled { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<string> EnabledHostNames { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.ExtendedLocation ExtendedLocation { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.HostingEnvironmentProfile HostingEnvironmentProfile { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<string> HostNames { get { throw null; } }
        public bool? HostNamesDisabled { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.HostNameSslState> HostNameSslStates { get { throw null; } }
        public bool? HttpsOnly { get { throw null; } set { } }
        public bool? HyperV { get { throw null; } set { } }
        public Azure.ResourceManager.Models.ManagedServiceIdentity Identity { get { throw null; } set { } }
        public System.Guid? InProgressOperationId { get { throw null; } }
        public bool? IsDefaultContainer { get { throw null; } }
        public bool? IsXenon { get { throw null; } set { } }
        public string KeyVaultReferenceIdentity { get { throw null; } set { } }
        public System.DateTimeOffset? LastModifiedTimeUtc { get { throw null; } }
        public int? MaxNumberOfWorkers { get { throw null; } }
        public string OutboundIpAddresses { get { throw null; } }
        public string PossibleOutboundIpAddresses { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.RedundancyMode? RedundancyMode { get { throw null; } set { } }
        public string RepositorySiteName { get { throw null; } }
        public bool? Reserved { get { throw null; } set { } }
        public string ResourceGroup { get { throw null; } }
        public bool? ScmSiteAlsoStopped { get { throw null; } set { } }
        public string ServerFarmId { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.SiteConfigProperties SiteConfig { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.SlotSwapStatus SlotSwapStatus { get { throw null; } }
        public string State { get { throw null; } }
        public bool? StorageAccountRequired { get { throw null; } set { } }
        public System.DateTimeOffset? SuspendedTill { get { throw null; } }
        public string TargetSwapSlot { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> TrafficManagerHostNames { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.UsageState? UsageState { get { throw null; } }
        public string VirtualNetworkSubnetId { get { throw null; } set { } }
    }
    public partial class WebSiteInstanceStatusData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public WebSiteInstanceStatusData() { }
        public string ConsoleUrl { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, Azure.ResourceManager.AppService.Models.ContainerInfo> Containers { get { throw null; } }
        public string DetectorUrl { get { throw null; } set { } }
        public string HealthCheckUrl { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.SiteRuntimeState? State { get { throw null; } set { } }
        public string StatusUrl { get { throw null; } set { } }
    }
    public partial class WebSiteSlotConfig : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected WebSiteSlotConfig() { }
        public virtual Azure.ResourceManager.AppService.SiteConfigData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.WebSiteSlotConfig> CreateOrUpdate(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.SiteConfigData siteConfig, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppService.WebSiteSlotConfig>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppService.SiteConfigData siteConfig, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.WebSiteSlotConfig> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.WebSiteSlotConfig>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppService.Models.SiteConfigurationSnapshotInfo> GetConfigurationSnapshotInfoSlot(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppService.Models.SiteConfigurationSnapshotInfo> GetConfigurationSnapshotInfoSlotAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.SiteSlotConfigSnapshot> GetSiteSlotConfigSnapshot(string snapshotId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.SiteSlotConfigSnapshot>> GetSiteSlotConfigSnapshotAsync(string snapshotId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppService.SiteSlotConfigSnapshotCollection GetSiteSlotConfigSnapshots() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppService.WebSiteSlotConfig> Update(Azure.ResourceManager.AppService.SiteConfigData siteConfig, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppService.WebSiteSlotConfig>> UpdateAsync(Azure.ResourceManager.AppService.SiteConfigData siteConfig, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class WorkerPoolResourceData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public WorkerPoolResourceData() { }
        public Azure.ResourceManager.AppService.Models.ComputeModeOptions? ComputeMode { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<string> InstanceNames { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.SkuDescription Sku { get { throw null; } set { } }
        public int? WorkerCount { get { throw null; } set { } }
        public string WorkerSize { get { throw null; } set { } }
        public int? WorkerSizeId { get { throw null; } set { } }
    }
}
namespace Azure.ResourceManager.AppService.Models
{
    public partial class AbnormalTimePeriod
    {
        public AbnormalTimePeriod() { }
        public System.DateTimeOffset? EndTime { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.DetectorAbnormalTimePeriod> Events { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.Solution> Solutions { get { throw null; } }
        public System.DateTimeOffset? StartTime { get { throw null; } set { } }
    }
    public partial class Address
    {
        public Address(string address1, string city, string country, string postalCode, string state) { }
        public string Address1 { get { throw null; } set { } }
        public string Address2 { get { throw null; } set { } }
        public string City { get { throw null; } set { } }
        public string Country { get { throw null; } set { } }
        public string PostalCode { get { throw null; } set { } }
        public string State { get { throw null; } set { } }
    }
    public partial class AddressResponse : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public AddressResponse() { }
        public string InternalIpAddress { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> OutboundIpAddresses { get { throw null; } }
        public string ServiceIpAddress { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.VirtualIPMapping> VipMappings { get { throw null; } }
    }
    public partial class AllowedPrincipals
    {
        public AllowedPrincipals() { }
        public System.Collections.Generic.IList<string> Groups { get { throw null; } }
        public System.Collections.Generic.IList<string> Identities { get { throw null; } }
    }
    public partial class AnalysisData
    {
        public AnalysisData() { }
        public System.Collections.Generic.IList<System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.NameValuePair>> Data { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.DataSource DataSource { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.DetectorDefinition DetectorDefinition { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.DiagnosticMetricSet> Metrics { get { throw null; } }
        public string Source { get { throw null; } set { } }
    }
    public partial class AppInsightsWebAppStackSettings
    {
        internal AppInsightsWebAppStackSettings() { }
        public bool? IsDefaultOff { get { throw null; } }
        public bool? IsSupported { get { throw null; } }
    }
    public partial class Apple
    {
        public Apple() { }
        public bool? Enabled { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> LoginScopes { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.AppleRegistration Registration { get { throw null; } set { } }
    }
    public partial class AppleRegistration
    {
        public AppleRegistration() { }
        public string ClientId { get { throw null; } set { } }
        public string ClientSecretSettingName { get { throw null; } set { } }
    }
    public partial class ApplicationLogsConfig
    {
        public ApplicationLogsConfig() { }
        public Azure.ResourceManager.AppService.Models.AzureBlobStorageApplicationLogsConfig AzureBlobStorage { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.AzureTableStorageApplicationLogsConfig AzureTableStorage { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.LogLevel? FileSystemLevel { get { throw null; } set { } }
    }
    public partial class ApplicationStack
    {
        public ApplicationStack() { }
        public string Dependency { get { throw null; } set { } }
        public string Display { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.ApplicationStack> Frameworks { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.ApplicationStack> IsDeprecated { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.StackMajorVersion> MajorVersions { get { throw null; } }
        public string Name { get { throw null; } set { } }
    }
    public partial class ApplicationStackResource : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public ApplicationStackResource() { }
        public string Dependency { get { throw null; } set { } }
        public string Display { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.ApplicationStack> Frameworks { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.ApplicationStack> IsDeprecated { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.StackMajorVersion> MajorVersions { get { throw null; } }
        public string NamePropertiesName { get { throw null; } set { } }
    }
    public partial class AppLogsConfiguration
    {
        public AppLogsConfiguration() { }
        public string Destination { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.LogAnalyticsConfiguration LogAnalyticsConfiguration { get { throw null; } set { } }
    }
    public partial class AppRegistration
    {
        public AppRegistration() { }
        public string AppId { get { throw null; } set { } }
        public string AppSecretSettingName { get { throw null; } set { } }
    }
    public partial class AppServiceCertificate
    {
        public AppServiceCertificate() { }
        public string KeyVaultId { get { throw null; } set { } }
        public string KeyVaultSecretName { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.KeyVaultSecretStatus? ProvisioningState { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AppServiceCertificateNotRenewableReason : System.IEquatable<Azure.ResourceManager.AppService.Models.AppServiceCertificateNotRenewableReason>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AppServiceCertificateNotRenewableReason(string value) { throw null; }
        public static Azure.ResourceManager.AppService.Models.AppServiceCertificateNotRenewableReason ExpirationNotInRenewalTimeRange { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.AppServiceCertificateNotRenewableReason RegistrationStatusNotSupportedForRenewal { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.AppServiceCertificateNotRenewableReason SubscriptionNotActive { get { throw null; } }
        public bool Equals(Azure.ResourceManager.AppService.Models.AppServiceCertificateNotRenewableReason other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.AppService.Models.AppServiceCertificateNotRenewableReason left, Azure.ResourceManager.AppService.Models.AppServiceCertificateNotRenewableReason right) { throw null; }
        public static implicit operator Azure.ResourceManager.AppService.Models.AppServiceCertificateNotRenewableReason (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.AppService.Models.AppServiceCertificateNotRenewableReason left, Azure.ResourceManager.AppService.Models.AppServiceCertificateNotRenewableReason right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AppServiceDomainPropertiesDomainNotRenewableReasonsItem : System.IEquatable<Azure.ResourceManager.AppService.Models.AppServiceDomainPropertiesDomainNotRenewableReasonsItem>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AppServiceDomainPropertiesDomainNotRenewableReasonsItem(string value) { throw null; }
        public static Azure.ResourceManager.AppService.Models.AppServiceDomainPropertiesDomainNotRenewableReasonsItem ExpirationNotInRenewalTimeRange { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.AppServiceDomainPropertiesDomainNotRenewableReasonsItem RegistrationStatusNotSupportedForRenewal { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.AppServiceDomainPropertiesDomainNotRenewableReasonsItem SubscriptionNotActive { get { throw null; } }
        public bool Equals(Azure.ResourceManager.AppService.Models.AppServiceDomainPropertiesDomainNotRenewableReasonsItem other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.AppService.Models.AppServiceDomainPropertiesDomainNotRenewableReasonsItem left, Azure.ResourceManager.AppService.Models.AppServiceDomainPropertiesDomainNotRenewableReasonsItem right) { throw null; }
        public static implicit operator Azure.ResourceManager.AppService.Models.AppServiceDomainPropertiesDomainNotRenewableReasonsItem (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.AppService.Models.AppServiceDomainPropertiesDomainNotRenewableReasonsItem left, Azure.ResourceManager.AppService.Models.AppServiceDomainPropertiesDomainNotRenewableReasonsItem right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class AppServiceEnvironmentAutoGenerated
    {
        public AppServiceEnvironmentAutoGenerated(Azure.ResourceManager.AppService.Models.VirtualNetworkProfile virtualNetwork) { }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.NameValuePair> ClusterSettings { get { throw null; } }
        public int? DedicatedHostCount { get { throw null; } set { } }
        public string DnsSuffix { get { throw null; } set { } }
        public int? FrontEndScaleFactor { get { throw null; } set { } }
        public bool? HasLinuxWorkers { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.LoadBalancingMode? InternalLoadBalancingMode { get { throw null; } set { } }
        public int? IpsslAddressCount { get { throw null; } set { } }
        public int? MaximumNumberOfMachines { get { throw null; } }
        public int? MultiRoleCount { get { throw null; } }
        public string MultiSize { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.HostingEnvironmentStatus? Status { get { throw null; } }
        public bool? Suspended { get { throw null; } }
        public System.Collections.Generic.IList<string> UserWhitelistedIpRanges { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.VirtualNetworkProfile VirtualNetwork { get { throw null; } set { } }
        public bool? ZoneRedundant { get { throw null; } set { } }
    }
    public enum AppServicePlanRestrictions
    {
        None = 0,
        Free = 1,
        Shared = 2,
        Basic = 3,
        Standard = 4,
        Premium = 5,
    }
    public partial class AppServiceRecommendation : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public AppServiceRecommendation() { }
        public string ActionName { get { throw null; } set { } }
        public string BladeName { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<string> CategoryTags { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.Channels? Channels { get { throw null; } set { } }
        public System.DateTimeOffset? CreationTime { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public int? Enabled { get { throw null; } set { } }
        public System.DateTimeOffset? EndTime { get { throw null; } set { } }
        public string ExtensionName { get { throw null; } set { } }
        public string ForwardLink { get { throw null; } set { } }
        public bool? IsDynamic { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.NotificationLevel? Level { get { throw null; } set { } }
        public string Message { get { throw null; } set { } }
        public System.DateTimeOffset? NextNotificationTime { get { throw null; } set { } }
        public System.DateTimeOffset? NotificationExpirationTime { get { throw null; } set { } }
        public System.DateTimeOffset? NotifiedTime { get { throw null; } set { } }
        public System.Guid? RecommendationId { get { throw null; } set { } }
        public string ResourceId { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.ResourceScopeType? ResourceScope { get { throw null; } set { } }
        public string RuleName { get { throw null; } set { } }
        public double? Score { get { throw null; } set { } }
        public System.DateTimeOffset? StartTime { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> States { get { throw null; } }
    }
    public partial class AppServiceResource : Azure.ResourceManager.Models.TrackedResourceData
    {
        public AppServiceResource(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public string Kind { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AppServiceSkuName : System.IEquatable<Azure.ResourceManager.AppService.Models.AppServiceSkuName>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AppServiceSkuName(string value) { throw null; }
        public static Azure.ResourceManager.AppService.Models.AppServiceSkuName Basic { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.AppServiceSkuName Dynamic { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.AppServiceSkuName ElasticIsolated { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.AppServiceSkuName ElasticPremium { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.AppServiceSkuName Free { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.AppServiceSkuName Isolated { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.AppServiceSkuName IsolatedV2 { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.AppServiceSkuName Premium { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.AppServiceSkuName PremiumContainer { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.AppServiceSkuName PremiumV2 { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.AppServiceSkuName PremiumV3 { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.AppServiceSkuName Shared { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.AppServiceSkuName Standard { get { throw null; } }
        public bool Equals(Azure.ResourceManager.AppService.Models.AppServiceSkuName other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.AppService.Models.AppServiceSkuName left, Azure.ResourceManager.AppService.Models.AppServiceSkuName right) { throw null; }
        public static implicit operator Azure.ResourceManager.AppService.Models.AppServiceSkuName (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.AppService.Models.AppServiceSkuName left, Azure.ResourceManager.AppService.Models.AppServiceSkuName right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class AppServiceUsage : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public AppServiceUsage() { }
        public Azure.ResourceManager.AppService.Models.ComputeModeOptions? ComputeMode { get { throw null; } }
        public long? CurrentValue { get { throw null; } }
        public string DisplayName { get { throw null; } }
        public long? Limit { get { throw null; } }
        public System.DateTimeOffset? NextResetTime { get { throw null; } }
        public string ResourceName { get { throw null; } }
        public string SiteMode { get { throw null; } }
        public string Unit { get { throw null; } }
    }
    public partial class ArcConfiguration
    {
        public ArcConfiguration() { }
        public Azure.ResourceManager.AppService.Models.StorageType? ArtifactsStorageType { get { throw null; } set { } }
        public string ArtifactStorageAccessMode { get { throw null; } set { } }
        public string ArtifactStorageClassName { get { throw null; } set { } }
        public string ArtifactStorageMountPath { get { throw null; } set { } }
        public string ArtifactStorageNodeName { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.FrontEndServiceType? FrontEndServiceKind { get { throw null; } set { } }
        public string KubeConfig { get { throw null; } set { } }
    }
    public partial class ArmPlan
    {
        internal ArmPlan() { }
        public string Name { get { throw null; } }
        public string Product { get { throw null; } }
        public string PromotionCode { get { throw null; } }
        public string Publisher { get { throw null; } }
        public string Version { get { throw null; } }
    }
    public partial class AuthPlatform
    {
        public AuthPlatform() { }
        public string ConfigFilePath { get { throw null; } set { } }
        public bool? Enabled { get { throw null; } set { } }
        public string RuntimeVersion { get { throw null; } set { } }
    }
    public partial class AutoHealActions
    {
        public AutoHealActions() { }
        public Azure.ResourceManager.AppService.Models.AutoHealActionType? ActionType { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.AutoHealCustomAction CustomAction { get { throw null; } set { } }
        public string MinProcessExecutionTime { get { throw null; } set { } }
    }
    public enum AutoHealActionType
    {
        Recycle = 0,
        LogEvent = 1,
        CustomAction = 2,
    }
    public partial class AutoHealCustomAction
    {
        public AutoHealCustomAction() { }
        public string Exe { get { throw null; } set { } }
        public string Parameters { get { throw null; } set { } }
    }
    public partial class AutoHealRules
    {
        public AutoHealRules() { }
        public Azure.ResourceManager.AppService.Models.AutoHealActions Actions { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.AutoHealTriggers Triggers { get { throw null; } set { } }
    }
    public partial class AutoHealTriggers
    {
        public AutoHealTriggers() { }
        public int? PrivateBytesInKB { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.RequestsBasedTrigger Requests { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.SlowRequestsBasedTrigger SlowRequests { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.SlowRequestsBasedTrigger> SlowRequestsWithPath { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.StatusCodesBasedTrigger> StatusCodes { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.StatusCodesRangeBasedTrigger> StatusCodesRange { get { throw null; } }
    }
    public partial class AzureActiveDirectory
    {
        public AzureActiveDirectory() { }
        public bool? Enabled { get { throw null; } set { } }
        public bool? IsAutoProvisioned { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.AzureActiveDirectoryLogin Login { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.AzureActiveDirectoryRegistration Registration { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.AzureActiveDirectoryValidation Validation { get { throw null; } set { } }
    }
    public partial class AzureActiveDirectoryLogin
    {
        public AzureActiveDirectoryLogin() { }
        public bool? DisableWWWAuthenticate { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> LoginParameters { get { throw null; } }
    }
    public partial class AzureActiveDirectoryRegistration
    {
        public AzureActiveDirectoryRegistration() { }
        public string ClientId { get { throw null; } set { } }
        public string ClientSecretCertificateIssuer { get { throw null; } set { } }
        public string ClientSecretCertificateSubjectAlternativeName { get { throw null; } set { } }
        public string ClientSecretCertificateThumbprint { get { throw null; } set { } }
        public string ClientSecretSettingName { get { throw null; } set { } }
        public string OpenIdIssuer { get { throw null; } set { } }
    }
    public partial class AzureActiveDirectoryValidation
    {
        public AzureActiveDirectoryValidation() { }
        public System.Collections.Generic.IList<string> AllowedAudiences { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.DefaultAuthorizationPolicy DefaultAuthorizationPolicy { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.JwtClaimChecks JwtClaimChecks { get { throw null; } set { } }
    }
    public partial class AzureBlobStorageApplicationLogsConfig
    {
        public AzureBlobStorageApplicationLogsConfig() { }
        public Azure.ResourceManager.AppService.Models.LogLevel? Level { get { throw null; } set { } }
        public int? RetentionInDays { get { throw null; } set { } }
        public string SasUrl { get { throw null; } set { } }
    }
    public partial class AzureBlobStorageHttpLogsConfig
    {
        public AzureBlobStorageHttpLogsConfig() { }
        public bool? Enabled { get { throw null; } set { } }
        public int? RetentionInDays { get { throw null; } set { } }
        public string SasUrl { get { throw null; } set { } }
    }
    public enum AzureResourceType
    {
        Website = 0,
        TrafficManager = 1,
    }
    public partial class AzureStaticWebApps
    {
        public AzureStaticWebApps() { }
        public bool? Enabled { get { throw null; } set { } }
        public string RegistrationClientId { get { throw null; } set { } }
    }
    public partial class AzureStorageInfoValue
    {
        public AzureStorageInfoValue() { }
        public string AccessKey { get { throw null; } set { } }
        public string AccountName { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.AzureStorageType? AzureStorageType { get { throw null; } set { } }
        public string MountPath { get { throw null; } set { } }
        public string ShareName { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.AzureStorageState? State { get { throw null; } }
    }
    public partial class AzureStoragePropertyDictionaryResource : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public AzureStoragePropertyDictionaryResource() { }
        public System.Collections.Generic.IDictionary<string, Azure.ResourceManager.AppService.Models.AzureStorageInfoValue> Properties { get { throw null; } }
    }
    public enum AzureStorageState
    {
        Ok = 0,
        InvalidCredentials = 1,
        InvalidShare = 2,
        NotValidated = 3,
    }
    public enum AzureStorageType
    {
        AzureFiles = 0,
        AzureBlob = 1,
    }
    public partial class AzureTableStorageApplicationLogsConfig
    {
        public AzureTableStorageApplicationLogsConfig(string sasUrl) { }
        public Azure.ResourceManager.AppService.Models.LogLevel? Level { get { throw null; } set { } }
        public string SasUrl { get { throw null; } set { } }
    }
    public enum BackupItemStatus
    {
        InProgress = 0,
        Failed = 1,
        Succeeded = 2,
        TimedOut = 3,
        Created = 4,
        Skipped = 5,
        PartiallySucceeded = 6,
        DeleteInProgress = 7,
        DeleteFailed = 8,
        Deleted = 9,
    }
    public partial class BackupRequest : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public BackupRequest() { }
        public string BackupName { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.BackupSchedule BackupSchedule { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.DatabaseBackupSetting> Databases { get { throw null; } }
        public bool? Enabled { get { throw null; } set { } }
        public string StorageAccountUrl { get { throw null; } set { } }
    }
    public enum BackupRestoreOperationType
    {
        Default = 0,
        Clone = 1,
        Relocation = 2,
        Snapshot = 3,
        CloudFS = 4,
    }
    public partial class BackupSchedule
    {
        public BackupSchedule(int frequencyInterval, Azure.ResourceManager.AppService.Models.FrequencyUnit frequencyUnit, bool keepAtLeastOneBackup, int retentionPeriodInDays) { }
        public int FrequencyInterval { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.FrequencyUnit FrequencyUnit { get { throw null; } set { } }
        public bool KeepAtLeastOneBackup { get { throw null; } set { } }
        public System.DateTimeOffset? LastExecutionTime { get { throw null; } }
        public int RetentionPeriodInDays { get { throw null; } set { } }
        public System.DateTimeOffset? StartTime { get { throw null; } set { } }
    }
    public partial class BillingMeter : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public BillingMeter() { }
        public string BillingLocation { get { throw null; } set { } }
        public string FriendlyName { get { throw null; } set { } }
        public string MeterId { get { throw null; } set { } }
        public double? Multiplier { get { throw null; } set { } }
        public string OsType { get { throw null; } set { } }
        public string ShortName { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BuildStatus : System.IEquatable<Azure.ResourceManager.AppService.Models.BuildStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BuildStatus(string value) { throw null; }
        public static Azure.ResourceManager.AppService.Models.BuildStatus Deleting { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.BuildStatus Deploying { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.BuildStatus Detached { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.BuildStatus Failed { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.BuildStatus Ready { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.BuildStatus Uploading { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.BuildStatus WaitingForDeployment { get { throw null; } }
        public bool Equals(Azure.ResourceManager.AppService.Models.BuildStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.AppService.Models.BuildStatus left, Azure.ResourceManager.AppService.Models.BuildStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.AppService.Models.BuildStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.AppService.Models.BuildStatus left, Azure.ResourceManager.AppService.Models.BuildStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public enum BuiltInAuthenticationProvider
    {
        AzureActiveDirectory = 0,
        Facebook = 1,
        Google = 2,
        MicrosoftAccount = 3,
        Twitter = 4,
        Github = 5,
    }
    public partial class Capability
    {
        public Capability() { }
        public string Name { get { throw null; } set { } }
        public string Reason { get { throw null; } set { } }
        public string Value { get { throw null; } set { } }
    }
    public partial class CertificateDetails
    {
        internal CertificateDetails() { }
        public string Issuer { get { throw null; } }
        public System.DateTimeOffset? NotAfter { get { throw null; } }
        public System.DateTimeOffset? NotBefore { get { throw null; } }
        public string RawData { get { throw null; } }
        public string SerialNumber { get { throw null; } }
        public string SignatureAlgorithm { get { throw null; } }
        public string Subject { get { throw null; } }
        public string Thumbprint { get { throw null; } }
        public int? Version { get { throw null; } }
    }
    public partial class CertificateEmail : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public CertificateEmail() { }
        public string EmailId { get { throw null; } set { } }
        public System.DateTimeOffset? TimeStamp { get { throw null; } set { } }
    }
    public partial class CertificateOrderAction : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public CertificateOrderAction() { }
        public Azure.ResourceManager.AppService.Models.CertificateOrderActionType? ActionType { get { throw null; } }
        public System.DateTimeOffset? CreatedAt { get { throw null; } }
    }
    public enum CertificateOrderActionType
    {
        Unknown = 0,
        CertificateIssued = 1,
        CertificateOrderCanceled = 2,
        CertificateOrderCreated = 3,
        CertificateRevoked = 4,
        DomainValidationComplete = 5,
        FraudDetected = 6,
        OrgNameChange = 7,
        OrgValidationComplete = 8,
        SanDrop = 9,
        FraudCleared = 10,
        CertificateExpired = 11,
        CertificateExpirationWarning = 12,
        FraudDocumentationRequired = 13,
    }
    public partial class CertificateOrderContact
    {
        internal CertificateOrderContact() { }
        public string Email { get { throw null; } }
        public string NameFirst { get { throw null; } }
        public string NameLast { get { throw null; } }
        public string Phone { get { throw null; } }
    }
    public enum CertificateOrderStatus
    {
        Pendingissuance = 0,
        Issued = 1,
        Revoked = 2,
        Canceled = 3,
        Denied = 4,
        Pendingrevocation = 5,
        PendingRekey = 6,
        Unused = 7,
        Expired = 8,
        NotSubmitted = 9,
    }
    public enum CertificateProductType
    {
        StandardDomainValidatedSsl = 0,
        StandardDomainValidatedWildCardSsl = 1,
    }
    public enum Channels
    {
        Notification = 0,
        Api = 1,
        Email = 2,
        Webhook = 3,
        All = 4,
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct CheckNameResourceTypes : System.IEquatable<Azure.ResourceManager.AppService.Models.CheckNameResourceTypes>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CheckNameResourceTypes(string value) { throw null; }
        public static Azure.ResourceManager.AppService.Models.CheckNameResourceTypes HostingEnvironment { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.CheckNameResourceTypes MicrosoftWebHostingEnvironments { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.CheckNameResourceTypes MicrosoftWebPublishingUsers { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.CheckNameResourceTypes MicrosoftWebSites { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.CheckNameResourceTypes MicrosoftWebSitesSlots { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.CheckNameResourceTypes PublishingUser { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.CheckNameResourceTypes Slot { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.CheckNameResourceTypes WebSite { get { throw null; } }
        public bool Equals(Azure.ResourceManager.AppService.Models.CheckNameResourceTypes other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.AppService.Models.CheckNameResourceTypes left, Azure.ResourceManager.AppService.Models.CheckNameResourceTypes right) { throw null; }
        public static implicit operator Azure.ResourceManager.AppService.Models.CheckNameResourceTypes (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.AppService.Models.CheckNameResourceTypes left, Azure.ResourceManager.AppService.Models.CheckNameResourceTypes right) { throw null; }
        public override string ToString() { throw null; }
    }
    public enum ClientCertMode
    {
        Required = 0,
        Optional = 1,
        OptionalInteractiveUser = 2,
    }
    public partial class ClientRegistration
    {
        public ClientRegistration() { }
        public string ClientId { get { throw null; } set { } }
        public string ClientSecretSettingName { get { throw null; } set { } }
    }
    public enum CloneAbilityResult
    {
        Cloneable = 0,
        PartiallyCloneable = 1,
        NotCloneable = 2,
    }
    public partial class CloningInfo
    {
        public CloningInfo(string sourceWebAppId) { }
        public System.Collections.Generic.IDictionary<string, string> AppSettingsOverrides { get { throw null; } }
        public bool? CloneCustomHostNames { get { throw null; } set { } }
        public bool? CloneSourceControl { get { throw null; } set { } }
        public bool? ConfigureLoadBalancing { get { throw null; } set { } }
        public System.Guid? CorrelationId { get { throw null; } set { } }
        public string HostingEnvironment { get { throw null; } set { } }
        public bool? Overwrite { get { throw null; } set { } }
        public string SourceWebAppId { get { throw null; } set { } }
        public string SourceWebAppLocation { get { throw null; } set { } }
        public string TrafficManagerProfileId { get { throw null; } set { } }
        public string TrafficManagerProfileName { get { throw null; } set { } }
    }
    public enum ComputeModeOptions
    {
        Shared = 0,
        Dedicated = 1,
        Dynamic = 2,
    }
    public partial class ConnectionStringDictionary : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public ConnectionStringDictionary() { }
        public System.Collections.Generic.IDictionary<string, Azure.ResourceManager.AppService.Models.ConnStringValueTypePair> Properties { get { throw null; } }
    }
    public enum ConnectionStringType
    {
        MySql = 0,
        SQLServer = 1,
        SQLAzure = 2,
        Custom = 3,
        NotificationHub = 4,
        ServiceBus = 5,
        EventHub = 6,
        ApiHub = 7,
        DocDb = 8,
        RedisCache = 9,
        PostgreSQL = 10,
    }
    public partial class ConnStringInfo
    {
        public ConnStringInfo() { }
        public string ConnectionString { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.ConnectionStringType? ConnectionStringType { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
    }
    public partial class ConnStringValueTypePair
    {
        public ConnStringValueTypePair(string value, Azure.ResourceManager.AppService.Models.ConnectionStringType connectionStringType) { }
        public Azure.ResourceManager.AppService.Models.ConnectionStringType ConnectionStringType { get { throw null; } set { } }
        public string Value { get { throw null; } set { } }
    }
    public partial class ContactInformation
    {
        public ContactInformation(string email, string nameFirst, string nameLast, string phone) { }
        public Azure.ResourceManager.AppService.Models.Address AddressMailing { get { throw null; } set { } }
        public string Email { get { throw null; } set { } }
        public string Fax { get { throw null; } set { } }
        public string JobTitle { get { throw null; } set { } }
        public string NameFirst { get { throw null; } set { } }
        public string NameLast { get { throw null; } set { } }
        public string NameMiddle { get { throw null; } set { } }
        public string Organization { get { throw null; } set { } }
        public string Phone { get { throw null; } set { } }
    }
    public partial class ContainerCpuStatistics
    {
        public ContainerCpuStatistics() { }
        public Azure.ResourceManager.AppService.Models.ContainerCpuUsage CpuUsage { get { throw null; } set { } }
        public int? OnlineCpuCount { get { throw null; } set { } }
        public long? SystemCpuUsage { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.ContainerThrottlingData ThrottlingData { get { throw null; } set { } }
    }
    public partial class ContainerCpuUsage
    {
        public ContainerCpuUsage() { }
        public long? KernelModeUsage { get { throw null; } set { } }
        public System.Collections.Generic.IList<long> PerCpuUsage { get { throw null; } }
        public long? TotalUsage { get { throw null; } set { } }
        public long? UserModeUsage { get { throw null; } set { } }
    }
    public partial class ContainerInfo
    {
        public ContainerInfo() { }
        public Azure.ResourceManager.AppService.Models.ContainerCpuStatistics CurrentCpuStats { get { throw null; } set { } }
        public System.DateTimeOffset? CurrentTimeStamp { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.ContainerNetworkInterfaceStatistics Eth0 { get { throw null; } set { } }
        public string Id { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.ContainerMemoryStatistics MemoryStats { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.ContainerCpuStatistics PreviousCpuStats { get { throw null; } set { } }
        public System.DateTimeOffset? PreviousTimeStamp { get { throw null; } set { } }
    }
    public partial class ContainerMemoryStatistics
    {
        public ContainerMemoryStatistics() { }
        public long? Limit { get { throw null; } set { } }
        public long? MaxUsage { get { throw null; } set { } }
        public long? Usage { get { throw null; } set { } }
    }
    public partial class ContainerNetworkInterfaceStatistics
    {
        public ContainerNetworkInterfaceStatistics() { }
        public long? RxBytes { get { throw null; } set { } }
        public long? RxDropped { get { throw null; } set { } }
        public long? RxErrors { get { throw null; } set { } }
        public long? RxPackets { get { throw null; } set { } }
        public long? TxBytes { get { throw null; } set { } }
        public long? TxDropped { get { throw null; } set { } }
        public long? TxErrors { get { throw null; } set { } }
        public long? TxPackets { get { throw null; } set { } }
    }
    public partial class ContainerThrottlingData
    {
        public ContainerThrottlingData() { }
        public int? Periods { get { throw null; } set { } }
        public int? ThrottledPeriods { get { throw null; } set { } }
        public int? ThrottledTime { get { throw null; } set { } }
    }
    public enum ContinuousWebJobStatus
    {
        Initializing = 0,
        Starting = 1,
        Running = 2,
        PendingRestart = 3,
        Stopped = 4,
    }
    public partial class CookieExpiration
    {
        public CookieExpiration() { }
        public Azure.ResourceManager.AppService.Models.CookieExpirationConvention? Convention { get { throw null; } set { } }
        public string TimeToExpiration { get { throw null; } set { } }
    }
    public enum CookieExpirationConvention
    {
        FixedTime = 0,
        IdentityProviderDerived = 1,
    }
    public partial class CorsSettings
    {
        public CorsSettings() { }
        public System.Collections.Generic.IList<string> AllowedOrigins { get { throw null; } }
        public bool? SupportCredentials { get { throw null; } set { } }
    }
    public partial class CsmMoveResourceEnvelope
    {
        public CsmMoveResourceEnvelope() { }
        public System.Collections.Generic.IList<string> Resources { get { throw null; } }
        public string TargetResourceGroup { get { throw null; } set { } }
    }
    public partial class CsmOperationDescription
    {
        internal CsmOperationDescription() { }
        public Azure.ResourceManager.AppService.Models.ServiceSpecification CsmOperationDescriptionServiceSpecification { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.CsmOperationDisplay Display { get { throw null; } }
        public bool? IsDataAction { get { throw null; } }
        public string Name { get { throw null; } }
        public string Origin { get { throw null; } }
    }
    public partial class CsmOperationDisplay
    {
        internal CsmOperationDisplay() { }
        public string Description { get { throw null; } }
        public string Operation { get { throw null; } }
        public string Provider { get { throw null; } }
        public string Resource { get { throw null; } }
    }
    public partial class CsmPublishingProfileOptions
    {
        public CsmPublishingProfileOptions() { }
        public Azure.ResourceManager.AppService.Models.PublishingProfileFormat? Format { get { throw null; } set { } }
        public bool? IncludeDisasterRecoveryEndpoints { get { throw null; } set { } }
    }
    public partial class CsmSlotEntity
    {
        public CsmSlotEntity(string targetSlot, bool preserveVnet) { }
        public bool PreserveVnet { get { throw null; } }
        public string TargetSlot { get { throw null; } }
    }
    public partial class CsmUsageQuota
    {
        internal CsmUsageQuota() { }
        public long? CurrentValue { get { throw null; } }
        public long? Limit { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.LocalizableString Name { get { throw null; } }
        public System.DateTimeOffset? NextResetTime { get { throw null; } }
        public string Unit { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct CustomDomainStatus : System.IEquatable<Azure.ResourceManager.AppService.Models.CustomDomainStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CustomDomainStatus(string value) { throw null; }
        public static Azure.ResourceManager.AppService.Models.CustomDomainStatus Adding { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.CustomDomainStatus Deleting { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.CustomDomainStatus Failed { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.CustomDomainStatus Ready { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.CustomDomainStatus RetrievingValidationToken { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.CustomDomainStatus Validating { get { throw null; } }
        public bool Equals(Azure.ResourceManager.AppService.Models.CustomDomainStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.AppService.Models.CustomDomainStatus left, Azure.ResourceManager.AppService.Models.CustomDomainStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.AppService.Models.CustomDomainStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.AppService.Models.CustomDomainStatus left, Azure.ResourceManager.AppService.Models.CustomDomainStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class CustomHostnameAnalysisResult : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public CustomHostnameAnalysisResult() { }
        public System.Collections.Generic.IList<string> AlternateCNameRecords { get { throw null; } }
        public System.Collections.Generic.IList<string> AlternateTxtRecords { get { throw null; } }
        public System.Collections.Generic.IList<string> ARecords { get { throw null; } }
        public System.Collections.Generic.IList<string> CNameRecords { get { throw null; } }
        public string ConflictingAppResourceId { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.ErrorEntity CustomDomainVerificationFailureInfo { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.DnsVerificationTestResult? CustomDomainVerificationTest { get { throw null; } }
        public bool? HasConflictAcrossSubscription { get { throw null; } }
        public bool? HasConflictOnScaleUnit { get { throw null; } }
        public bool? IsHostnameAlreadyVerified { get { throw null; } }
        public System.Collections.Generic.IList<string> TxtRecords { get { throw null; } }
    }
    public enum CustomHostNameDnsRecordType
    {
        CName = 0,
        A = 1,
    }
    public partial class CustomOpenIdConnectProvider
    {
        public CustomOpenIdConnectProvider() { }
        public bool? Enabled { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.OpenIdConnectLogin Login { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.OpenIdConnectRegistration Registration { get { throw null; } set { } }
    }
    public partial class DatabaseBackupSetting
    {
        public DatabaseBackupSetting(Azure.ResourceManager.AppService.Models.DatabaseType databaseType) { }
        public string ConnectionString { get { throw null; } set { } }
        public string ConnectionStringName { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.DatabaseType DatabaseType { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DatabaseType : System.IEquatable<Azure.ResourceManager.AppService.Models.DatabaseType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DatabaseType(string value) { throw null; }
        public static Azure.ResourceManager.AppService.Models.DatabaseType LocalMySql { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.DatabaseType MySql { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.DatabaseType PostgreSql { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.DatabaseType SqlAzure { get { throw null; } }
        public bool Equals(Azure.ResourceManager.AppService.Models.DatabaseType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.AppService.Models.DatabaseType left, Azure.ResourceManager.AppService.Models.DatabaseType right) { throw null; }
        public static implicit operator Azure.ResourceManager.AppService.Models.DatabaseType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.AppService.Models.DatabaseType left, Azure.ResourceManager.AppService.Models.DatabaseType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class DataProviderMetadata
    {
        public DataProviderMetadata() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppService.Models.KeyValuePairStringObject> PropertyBag { get { throw null; } }
        public string ProviderName { get { throw null; } set { } }
    }
    public partial class DataSource
    {
        public DataSource() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.NameValuePair> DataSourceUri { get { throw null; } }
        public System.Collections.Generic.IList<string> Instructions { get { throw null; } }
    }
    public partial class DataTableResponseColumn
    {
        public DataTableResponseColumn() { }
        public string ColumnName { get { throw null; } set { } }
        public string ColumnType { get { throw null; } set { } }
        public string DataType { get { throw null; } set { } }
    }
    public partial class DataTableResponseObject
    {
        public DataTableResponseObject() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.DataTableResponseColumn> Columns { get { throw null; } }
        public System.Collections.Generic.IList<System.Collections.Generic.IList<string>> Rows { get { throw null; } }
        public string TableName { get { throw null; } set { } }
    }
    public partial class DefaultAuthorizationPolicy
    {
        public DefaultAuthorizationPolicy() { }
        public System.Collections.Generic.IList<string> AllowedApplications { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.AllowedPrincipals AllowedPrincipals { get { throw null; } set { } }
    }
    public partial class DeletedAppRestoreRequest : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public DeletedAppRestoreRequest() { }
        public string DeletedSiteId { get { throw null; } set { } }
        public bool? RecoverConfiguration { get { throw null; } set { } }
        public string SnapshotTime { get { throw null; } set { } }
        public bool? UseDRSecondary { get { throw null; } set { } }
    }
    public partial class DeploymentLocations
    {
        internal DeploymentLocations() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppService.Models.HostingEnvironmentDeploymentInfo> HostingEnvironmentDeploymentInfos { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppService.Models.AppServiceEnvironmentAutoGenerated> HostingEnvironments { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppService.Models.GeoRegion> Locations { get { throw null; } }
    }
    public partial class DetectorAbnormalTimePeriod
    {
        public DetectorAbnormalTimePeriod() { }
        public System.DateTimeOffset? EndTime { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.IssueType? IssueType { get { throw null; } set { } }
        public string Message { get { throw null; } set { } }
        public System.Collections.Generic.IList<System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.NameValuePair>> MetaData { get { throw null; } }
        public double? Priority { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.Solution> Solutions { get { throw null; } }
        public string Source { get { throw null; } set { } }
        public System.DateTimeOffset? StartTime { get { throw null; } set { } }
    }
    public partial class DetectorDefinition
    {
        public DetectorDefinition() { }
        public string Description { get { throw null; } }
        public string DisplayName { get { throw null; } }
        public bool? IsEnabled { get { throw null; } }
        public double? Rank { get { throw null; } }
    }
    public partial class DetectorInfo
    {
        public DetectorInfo() { }
        public System.Collections.Generic.IReadOnlyList<string> AnalysisType { get { throw null; } }
        public string Author { get { throw null; } }
        public string Category { get { throw null; } }
        public string Description { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.DetectorType? DetectorType { get { throw null; } }
        public string Id { get { throw null; } }
        public string Name { get { throw null; } }
        public float? Score { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppService.Models.SupportTopic> SupportTopicList { get { throw null; } }
    }
    public enum DetectorType
    {
        Detector = 0,
        Analysis = 1,
        CategoryOverview = 2,
    }
    public partial class DiagnosticAnalysis : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public DiagnosticAnalysis() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.AbnormalTimePeriod> AbnormalTimePeriods { get { throw null; } }
        public System.DateTimeOffset? EndTime { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.DetectorDefinition> NonCorrelatedDetectors { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.AnalysisData> Payload { get { throw null; } }
        public System.DateTimeOffset? StartTime { get { throw null; } set { } }
    }
    public partial class DiagnosticData
    {
        public DiagnosticData() { }
        public Azure.ResourceManager.AppService.Models.Rendering RenderingProperties { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.DataTableResponseObject Table { get { throw null; } set { } }
    }
    public partial class DiagnosticDetectorResponse : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public DiagnosticDetectorResponse() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.DetectorAbnormalTimePeriod> AbnormalTimePeriods { get { throw null; } }
        public System.Collections.Generic.IList<System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.NameValuePair>> Data { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.DataSource DataSource { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.DetectorDefinition DetectorDefinition { get { throw null; } set { } }
        public System.DateTimeOffset? EndTime { get { throw null; } set { } }
        public bool? IssueDetected { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.DiagnosticMetricSet> Metrics { get { throw null; } }
        public System.DateTimeOffset? StartTime { get { throw null; } set { } }
    }
    public partial class DiagnosticMetricSample
    {
        public DiagnosticMetricSample() { }
        public bool? IsAggregated { get { throw null; } set { } }
        public double? Maximum { get { throw null; } set { } }
        public double? Minimum { get { throw null; } set { } }
        public string RoleInstance { get { throw null; } set { } }
        public System.DateTimeOffset? Timestamp { get { throw null; } set { } }
        public double? Total { get { throw null; } set { } }
    }
    public partial class DiagnosticMetricSet
    {
        public DiagnosticMetricSet() { }
        public System.DateTimeOffset? EndTime { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public System.DateTimeOffset? StartTime { get { throw null; } set { } }
        public string TimeGrain { get { throw null; } set { } }
        public string Unit { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.DiagnosticMetricSample> Values { get { throw null; } }
    }
    public partial class Dimension
    {
        internal Dimension() { }
        public string DisplayName { get { throw null; } }
        public string InternalName { get { throw null; } }
        public string Name { get { throw null; } }
        public bool? ToBeExportedForShoebox { get { throw null; } }
    }
    public enum DnsType
    {
        AzureDns = 0,
        DefaultDomainRegistrarDns = 1,
    }
    public enum DnsVerificationTestResult
    {
        Passed = 0,
        Failed = 1,
        Skipped = 2,
    }
    public partial class DomainAvailabilityCheckResult
    {
        internal DomainAvailabilityCheckResult() { }
        public bool? Available { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.DomainType? DomainType { get { throw null; } }
        public string Name { get { throw null; } }
    }
    public partial class DomainControlCenterSsoRequest
    {
        internal DomainControlCenterSsoRequest() { }
        public string PostParameterKey { get { throw null; } }
        public string PostParameterValue { get { throw null; } }
        public string Url { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DomainNotRenewableReasons : System.IEquatable<Azure.ResourceManager.AppService.Models.DomainNotRenewableReasons>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DomainNotRenewableReasons(string value) { throw null; }
        public static Azure.ResourceManager.AppService.Models.DomainNotRenewableReasons ExpirationNotInRenewalTimeRange { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.DomainNotRenewableReasons RegistrationStatusNotSupportedForRenewal { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.DomainNotRenewableReasons SubscriptionNotActive { get { throw null; } }
        public bool Equals(Azure.ResourceManager.AppService.Models.DomainNotRenewableReasons other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.AppService.Models.DomainNotRenewableReasons left, Azure.ResourceManager.AppService.Models.DomainNotRenewableReasons right) { throw null; }
        public static implicit operator Azure.ResourceManager.AppService.Models.DomainNotRenewableReasons (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.AppService.Models.DomainNotRenewableReasons left, Azure.ResourceManager.AppService.Models.DomainNotRenewableReasons right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class DomainPurchaseConsent
    {
        public DomainPurchaseConsent() { }
        public System.DateTimeOffset? AgreedAt { get { throw null; } set { } }
        public string AgreedBy { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> AgreementKeys { get { throw null; } }
    }
    public partial class DomainRecommendationSearchParameters
    {
        public DomainRecommendationSearchParameters() { }
        public string Keywords { get { throw null; } set { } }
        public int? MaxDomainRecommendations { get { throw null; } set { } }
    }
    public enum DomainStatus
    {
        Unknown = 0,
        Active = 1,
        Awaiting = 2,
        Cancelled = 3,
        Confiscated = 4,
        Disabled = 5,
        Excluded = 6,
        Expired = 7,
        Failed = 8,
        Held = 9,
        Locked = 10,
        Parked = 11,
        Pending = 12,
        Reserved = 13,
        Reverted = 14,
        Suspended = 15,
        Transferred = 16,
        Unlocked = 17,
        Unparked = 18,
        Updated = 19,
        JsonConverterFailed = 20,
    }
    public enum DomainType
    {
        Regular = 0,
        SoftDeleted = 1,
    }
    public partial class EndpointDependency
    {
        internal EndpointDependency() { }
        public string DomainName { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppService.Models.EndpointDetail> EndpointDetails { get { throw null; } }
    }
    public partial class EndpointDetail
    {
        internal EndpointDetail() { }
        public string IpAddress { get { throw null; } }
        public bool? IsAccessible { get { throw null; } }
        public double? Latency { get { throw null; } }
        public int? Port { get { throw null; } }
    }
    public partial class ErrorEntity
    {
        internal ErrorEntity() { }
        public string Code { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppService.Models.ErrorEntity> Details { get { throw null; } }
        public string ExtendedCode { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppService.Models.ErrorEntity> InnerErrors { get { throw null; } }
        public string Message { get { throw null; } }
        public string MessageTemplate { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> Parameters { get { throw null; } }
        public string Target { get { throw null; } }
    }
    public partial class ExtendedLocation
    {
        public ExtendedLocation() { }
        public string ExtendedLocationType { get { throw null; } }
        public string Name { get { throw null; } set { } }
    }
    public partial class Facebook
    {
        public Facebook() { }
        public bool? Enabled { get { throw null; } set { } }
        public string GraphApiVersion { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> LoginScopes { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.AppRegistration Registration { get { throw null; } set { } }
    }
    public partial class FileSystemHttpLogsConfig
    {
        public FileSystemHttpLogsConfig() { }
        public bool? Enabled { get { throw null; } set { } }
        public int? RetentionInDays { get { throw null; } set { } }
        public int? RetentionInMb { get { throw null; } set { } }
    }
    public partial class ForwardProxy
    {
        public ForwardProxy() { }
        public Azure.ResourceManager.AppService.Models.ForwardProxyConvention? Convention { get { throw null; } set { } }
        public string CustomHostHeaderName { get { throw null; } set { } }
        public string CustomProtoHeaderName { get { throw null; } set { } }
    }
    public enum ForwardProxyConvention
    {
        NoProxy = 0,
        Standard = 1,
        Custom = 2,
    }
    public enum FrequencyUnit
    {
        Day = 0,
        Hour = 1,
    }
    public enum FrontEndServiceType
    {
        NodePort = 0,
        LoadBalancer = 1,
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct FtpsState : System.IEquatable<Azure.ResourceManager.AppService.Models.FtpsState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public FtpsState(string value) { throw null; }
        public static Azure.ResourceManager.AppService.Models.FtpsState AllAllowed { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.FtpsState Disabled { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.FtpsState FtpsOnly { get { throw null; } }
        public bool Equals(Azure.ResourceManager.AppService.Models.FtpsState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.AppService.Models.FtpsState left, Azure.ResourceManager.AppService.Models.FtpsState right) { throw null; }
        public static implicit operator Azure.ResourceManager.AppService.Models.FtpsState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.AppService.Models.FtpsState left, Azure.ResourceManager.AppService.Models.FtpsState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class FunctionAppMajorVersion
    {
        internal FunctionAppMajorVersion() { }
        public string DisplayText { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppService.Models.FunctionAppMinorVersion> MinorVersions { get { throw null; } }
        public string Value { get { throw null; } }
    }
    public partial class FunctionAppMinorVersion
    {
        internal FunctionAppMinorVersion() { }
        public string DisplayText { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.FunctionAppRuntimes StackSettings { get { throw null; } }
        public string Value { get { throw null; } }
    }
    public partial class FunctionAppRuntimes
    {
        internal FunctionAppRuntimes() { }
        public Azure.ResourceManager.AppService.Models.FunctionAppRuntimeSettings LinuxRuntimeSettings { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.FunctionAppRuntimeSettings WindowsRuntimeSettings { get { throw null; } }
    }
    public partial class FunctionAppRuntimeSettings
    {
        internal FunctionAppRuntimeSettings() { }
        public Azure.ResourceManager.AppService.Models.AppInsightsWebAppStackSettings AppInsightsSettings { get { throw null; } }
        public System.Collections.Generic.IReadOnlyDictionary<string, string> AppSettingsDictionary { get { throw null; } }
        public System.DateTimeOffset? EndOfLifeDate { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.GitHubActionWebAppStackSettings GitHubActionSettings { get { throw null; } }
        public bool? IsAutoUpdate { get { throw null; } }
        public bool? IsDefault { get { throw null; } }
        public bool? IsDeprecated { get { throw null; } }
        public bool? IsEarlyAccess { get { throw null; } }
        public bool? IsHidden { get { throw null; } }
        public bool? IsPreview { get { throw null; } }
        public bool? RemoteDebuggingSupported { get { throw null; } }
        public string RuntimeVersion { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.SiteConfigPropertiesDictionary SiteConfigPropertiesDictionary { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> SupportedFunctionsExtensionVersions { get { throw null; } }
    }
    public partial class FunctionAppStack : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public FunctionAppStack() { }
        public string DisplayText { get { throw null; } }
        public string Location { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppService.Models.FunctionAppMajorVersion> MajorVersions { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.StackPreferredOs? PreferredOs { get { throw null; } }
        public string Value { get { throw null; } }
    }
    public partial class FunctionSecrets
    {
        internal FunctionSecrets() { }
        public string Key { get { throw null; } }
        public string TriggerUrl { get { throw null; } }
    }
    public partial class GeoRegion : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public GeoRegion() { }
        public string Description { get { throw null; } }
        public string DisplayName { get { throw null; } }
        public string OrgDomain { get { throw null; } }
    }
    public partial class GitHub
    {
        public GitHub() { }
        public bool? Enabled { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> LoginScopes { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.ClientRegistration Registration { get { throw null; } set { } }
    }
    public partial class GitHubActionCodeConfiguration
    {
        public GitHubActionCodeConfiguration() { }
        public string RuntimeStack { get { throw null; } set { } }
        public string RuntimeVersion { get { throw null; } set { } }
    }
    public partial class GitHubActionConfiguration
    {
        public GitHubActionConfiguration() { }
        public Azure.ResourceManager.AppService.Models.GitHubActionCodeConfiguration CodeConfiguration { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.GitHubActionContainerConfiguration ContainerConfiguration { get { throw null; } set { } }
        public bool? GenerateWorkflowFile { get { throw null; } set { } }
        public bool? IsLinux { get { throw null; } set { } }
    }
    public partial class GitHubActionContainerConfiguration
    {
        public GitHubActionContainerConfiguration() { }
        public string ImageName { get { throw null; } set { } }
        public string Password { get { throw null; } set { } }
        public string ServerUrl { get { throw null; } set { } }
        public string Username { get { throw null; } set { } }
    }
    public partial class GitHubActionWebAppStackSettings
    {
        internal GitHubActionWebAppStackSettings() { }
        public bool? IsSupported { get { throw null; } }
        public string SupportedVersion { get { throw null; } }
    }
    public partial class GlobalCsmSkuDescription
    {
        internal GlobalCsmSkuDescription() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppService.Models.Capability> Capabilities { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.SkuCapacity Capacity { get { throw null; } }
        public string Family { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> Locations { get { throw null; } }
        public string Name { get { throw null; } }
        public string Size { get { throw null; } }
        public string Tier { get { throw null; } }
    }
    public partial class GlobalValidation
    {
        public GlobalValidation() { }
        public System.Collections.Generic.IList<string> ExcludedPaths { get { throw null; } }
        public string RedirectToProvider { get { throw null; } set { } }
        public bool? RequireAuthentication { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.UnauthenticatedClientActionV2? UnauthenticatedClientAction { get { throw null; } set { } }
    }
    public partial class Google
    {
        public Google() { }
        public bool? Enabled { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> LoginScopes { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.ClientRegistration Registration { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> ValidationAllowedAudiences { get { throw null; } }
    }
    public partial class HandlerMapping
    {
        public HandlerMapping() { }
        public string Arguments { get { throw null; } set { } }
        public string Extension { get { throw null; } set { } }
        public string ScriptProcessor { get { throw null; } set { } }
    }
    public partial class HostingEnvironmentDeploymentInfo
    {
        internal HostingEnvironmentDeploymentInfo() { }
        public string Location { get { throw null; } }
        public string Name { get { throw null; } }
    }
    public partial class HostingEnvironmentDiagnostics
    {
        internal HostingEnvironmentDiagnostics() { }
        public string DiagnosticsOutput { get { throw null; } }
        public string Name { get { throw null; } }
    }
    public partial class HostingEnvironmentProfile
    {
        public HostingEnvironmentProfile() { }
        public string Id { get { throw null; } set { } }
        public string Name { get { throw null; } }
        public string ResourceType { get { throw null; } }
    }
    public enum HostingEnvironmentStatus
    {
        Preparing = 0,
        Ready = 1,
        Scaling = 2,
        Deleting = 3,
    }
    public partial class HostKeys
    {
        internal HostKeys() { }
        public System.Collections.Generic.IReadOnlyDictionary<string, string> FunctionKeys { get { throw null; } }
        public string MasterKey { get { throw null; } }
        public System.Collections.Generic.IReadOnlyDictionary<string, string> SystemKeys { get { throw null; } }
    }
    public partial class HostName
    {
        internal HostName() { }
        public string AzureResourceName { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.AzureResourceType? AzureResourceType { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.CustomHostNameDnsRecordType? CustomHostNameDnsRecordType { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.HostNameType? HostNameType { get { throw null; } }
        public string Name { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> SiteNames { get { throw null; } }
    }
    public partial class HostNameSslState
    {
        public HostNameSslState() { }
        public Azure.ResourceManager.AppService.Models.HostType? HostType { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.SslState? SslState { get { throw null; } set { } }
        public string Thumbprint { get { throw null; } set { } }
        public bool? ToUpdate { get { throw null; } set { } }
        public string VirtualIP { get { throw null; } set { } }
    }
    public enum HostNameType
    {
        Verified = 0,
        Managed = 1,
    }
    public enum HostType
    {
        Standard = 0,
        Repository = 1,
    }
    public partial class HttpLogsConfig
    {
        public HttpLogsConfig() { }
        public Azure.ResourceManager.AppService.Models.AzureBlobStorageHttpLogsConfig AzureBlobStorage { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.FileSystemHttpLogsConfig FileSystem { get { throw null; } set { } }
    }
    public partial class HttpSettings
    {
        public HttpSettings() { }
        public Azure.ResourceManager.AppService.Models.ForwardProxy ForwardProxy { get { throw null; } set { } }
        public bool? RequireHttps { get { throw null; } set { } }
        public string RoutesApiPrefix { get { throw null; } set { } }
    }
    public partial class HybridConnectionKey : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public HybridConnectionKey() { }
        public string SendKeyName { get { throw null; } }
        public string SendKeyValue { get { throw null; } }
    }
    public partial class IdentityProviders
    {
        public IdentityProviders() { }
        public Azure.ResourceManager.AppService.Models.Apple Apple { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.AzureActiveDirectory AzureActiveDirectory { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.AzureStaticWebApps AzureStaticWebApps { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, Azure.ResourceManager.AppService.Models.CustomOpenIdConnectProvider> CustomOpenIdConnectProviders { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.Facebook Facebook { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.GitHub GitHub { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.Google Google { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.LegacyMicrosoftAccount LegacyMicrosoftAccount { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.Twitter Twitter { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct InAvailabilityReasonType : System.IEquatable<Azure.ResourceManager.AppService.Models.InAvailabilityReasonType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public InAvailabilityReasonType(string value) { throw null; }
        public static Azure.ResourceManager.AppService.Models.InAvailabilityReasonType AlreadyExists { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.InAvailabilityReasonType Invalid { get { throw null; } }
        public bool Equals(Azure.ResourceManager.AppService.Models.InAvailabilityReasonType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.AppService.Models.InAvailabilityReasonType left, Azure.ResourceManager.AppService.Models.InAvailabilityReasonType right) { throw null; }
        public static implicit operator Azure.ResourceManager.AppService.Models.InAvailabilityReasonType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.AppService.Models.InAvailabilityReasonType left, Azure.ResourceManager.AppService.Models.InAvailabilityReasonType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class InboundEnvironmentEndpoint
    {
        internal InboundEnvironmentEndpoint() { }
        public string Description { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> Endpoints { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> Ports { get { throw null; } }
    }
    public enum InsightStatus
    {
        None = 0,
        Critical = 1,
        Warning = 2,
        Info = 3,
        Success = 4,
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct IpFilterTag : System.IEquatable<Azure.ResourceManager.AppService.Models.IpFilterTag>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public IpFilterTag(string value) { throw null; }
        public static Azure.ResourceManager.AppService.Models.IpFilterTag Default { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.IpFilterTag ServiceTag { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.IpFilterTag XffProxy { get { throw null; } }
        public bool Equals(Azure.ResourceManager.AppService.Models.IpFilterTag other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.AppService.Models.IpFilterTag left, Azure.ResourceManager.AppService.Models.IpFilterTag right) { throw null; }
        public static implicit operator Azure.ResourceManager.AppService.Models.IpFilterTag (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.AppService.Models.IpFilterTag left, Azure.ResourceManager.AppService.Models.IpFilterTag right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class IpSecurityRestriction
    {
        public IpSecurityRestriction() { }
        public string Action { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, System.Collections.Generic.IList<string>> Headers { get { throw null; } }
        public string IpAddress { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public int? Priority { get { throw null; } set { } }
        public string SubnetMask { get { throw null; } set { } }
        public int? SubnetTrafficTag { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.IpFilterTag? Tag { get { throw null; } set { } }
        public string VnetSubnetResourceId { get { throw null; } set { } }
        public int? VnetTrafficTag { get { throw null; } set { } }
    }
    public enum IssueType
    {
        ServiceIncident = 0,
        AppDeployment = 1,
        AppCrash = 2,
        RuntimeIssueDetected = 3,
        AseDeployment = 4,
        UserIssue = 5,
        PlatformIssue = 6,
        Other = 7,
    }
    public partial class JwtClaimChecks
    {
        public JwtClaimChecks() { }
        public System.Collections.Generic.IList<string> AllowedClientApplications { get { throw null; } }
        public System.Collections.Generic.IList<string> AllowedGroups { get { throw null; } }
    }
    public partial class KeyInfo
    {
        public KeyInfo() { }
        public string Name { get { throw null; } set { } }
        public string Value { get { throw null; } set { } }
    }
    public partial class KeyValuePairStringObject
    {
        internal KeyValuePairStringObject() { }
        public string Key { get { throw null; } }
        public System.BinaryData Value { get { throw null; } }
    }
    public enum KeyVaultSecretStatus
    {
        Unknown = 0,
        Initialized = 1,
        WaitingOnCertificateOrder = 2,
        Succeeded = 3,
        CertificateOrderFailed = 4,
        OperationNotPermittedOnKeyVault = 5,
        AzureServiceUnauthorizedToAccessKeyVault = 6,
        KeyVaultDoesNotExist = 7,
        KeyVaultSecretDoesNotExist = 8,
        UnknownError = 9,
        ExternalPrivateKey = 10,
    }
    public partial class KubeEnvironmentProfile
    {
        public KubeEnvironmentProfile() { }
        public string Id { get { throw null; } set { } }
        public string Name { get { throw null; } }
        public string ResourceType { get { throw null; } }
    }
    public enum KubeEnvironmentProvisioningState
    {
        Succeeded = 0,
        Failed = 1,
        Canceled = 2,
        Waiting = 3,
        InitializationInProgress = 4,
        InfrastructureSetupInProgress = 5,
        InfrastructureSetupComplete = 6,
        ScheduledForDelete = 7,
        UpgradeRequested = 8,
        UpgradeFailed = 9,
    }
    public partial class LegacyMicrosoftAccount
    {
        public LegacyMicrosoftAccount() { }
        public bool? Enabled { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> LoginScopes { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.ClientRegistration Registration { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> ValidationAllowedAudiences { get { throw null; } }
    }
    public partial class LinuxJavaContainerSettings
    {
        internal LinuxJavaContainerSettings() { }
        public System.DateTimeOffset? EndOfLifeDate { get { throw null; } }
        public bool? IsAutoUpdate { get { throw null; } }
        public bool? IsDeprecated { get { throw null; } }
        public bool? IsEarlyAccess { get { throw null; } }
        public bool? IsHidden { get { throw null; } }
        public bool? IsPreview { get { throw null; } }
        public string Java11Runtime { get { throw null; } }
        public string Java8Runtime { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct LoadBalancingMode : System.IEquatable<Azure.ResourceManager.AppService.Models.LoadBalancingMode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public LoadBalancingMode(string value) { throw null; }
        public static Azure.ResourceManager.AppService.Models.LoadBalancingMode None { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.LoadBalancingMode Publishing { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.LoadBalancingMode Web { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.LoadBalancingMode WebPublishing { get { throw null; } }
        public bool Equals(Azure.ResourceManager.AppService.Models.LoadBalancingMode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.AppService.Models.LoadBalancingMode left, Azure.ResourceManager.AppService.Models.LoadBalancingMode right) { throw null; }
        public static implicit operator Azure.ResourceManager.AppService.Models.LoadBalancingMode (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.AppService.Models.LoadBalancingMode left, Azure.ResourceManager.AppService.Models.LoadBalancingMode right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class LocalizableString
    {
        internal LocalizableString() { }
        public string LocalizedValue { get { throw null; } }
        public string Value { get { throw null; } }
    }
    public partial class LogAnalyticsConfiguration
    {
        public LogAnalyticsConfiguration() { }
        public string CustomerId { get { throw null; } set { } }
        public string SharedKey { get { throw null; } set { } }
    }
    public partial class LoginInformation
    {
        public LoginInformation() { }
        public System.Collections.Generic.IList<string> AllowedExternalRedirectUrls { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.CookieExpiration CookieExpiration { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.Nonce Nonce { get { throw null; } set { } }
        public bool? PreserveUrlFragmentsForLogins { get { throw null; } set { } }
        public string RoutesLogoutEndpoint { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.TokenStore TokenStore { get { throw null; } set { } }
    }
    public enum LogLevel
    {
        Off = 0,
        Verbose = 1,
        Information = 2,
        Warning = 3,
        Error = 4,
    }
    public partial class LogSpecification
    {
        internal LogSpecification() { }
        public System.TimeSpan? BlobDuration { get { throw null; } }
        public string DisplayName { get { throw null; } }
        public string LogFilterPattern { get { throw null; } }
        public string Name { get { throw null; } }
    }
    public enum ManagedPipelineMode
    {
        Integrated = 0,
        Classic = 1,
    }
    public partial class MetricAvailability
    {
        internal MetricAvailability() { }
        public System.TimeSpan? BlobDuration { get { throw null; } }
        public string TimeGrain { get { throw null; } }
    }
    public partial class MetricSpecification
    {
        internal MetricSpecification() { }
        public string AggregationType { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppService.Models.MetricAvailability> Availabilities { get { throw null; } }
        public string Category { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppService.Models.Dimension> Dimensions { get { throw null; } }
        public string DisplayDescription { get { throw null; } }
        public string DisplayName { get { throw null; } }
        public bool? EnableRegionalMdmAccount { get { throw null; } }
        public bool? FillGapWithZero { get { throw null; } }
        public bool? IsInternal { get { throw null; } }
        public string MetricFilterPattern { get { throw null; } }
        public string Name { get { throw null; } }
        public string SourceMdmAccount { get { throw null; } }
        public string SourceMdmNamespace { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> SupportedAggregationTypes { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> SupportedTimeGrainTypes { get { throw null; } }
        public bool? SupportsInstanceLevelAggregation { get { throw null; } }
        public string Unit { get { throw null; } }
    }
    public partial class MigrateMySqlRequest : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public MigrateMySqlRequest() { }
        public string ConnectionString { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.MySqlMigrationType? MigrationType { get { throw null; } set { } }
    }
    public partial class MsDeploy : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public MsDeploy() { }
        public bool? AppOffline { get { throw null; } set { } }
        public string ConnectionString { get { throw null; } set { } }
        public string DbType { get { throw null; } set { } }
        public System.Uri PackageUri { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> SetParameters { get { throw null; } }
        public System.Uri SetParametersXmlFileUri { get { throw null; } set { } }
        public bool? SkipAppData { get { throw null; } set { } }
    }
    public partial class MsDeployLog : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public MsDeployLog() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppService.Models.MsDeployLogEntry> Entries { get { throw null; } }
    }
    public partial class MsDeployLogEntry
    {
        internal MsDeployLogEntry() { }
        public string Message { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.MSDeployLogEntryType? MSDeployLogEntryType { get { throw null; } }
        public System.DateTimeOffset? Time { get { throw null; } }
    }
    public enum MSDeployLogEntryType
    {
        Message = 0,
        Warning = 1,
        Error = 2,
    }
    public enum MSDeployProvisioningState
    {
        Accepted = 0,
        Running = 1,
        Succeeded = 2,
        Failed = 3,
        Canceled = 4,
    }
    public enum MySqlMigrationType
    {
        LocalToRemote = 0,
        RemoteToLocal = 1,
    }
    public partial class NameIdentifier
    {
        public NameIdentifier() { }
        public string Name { get { throw null; } set { } }
    }
    public partial class NameValuePair
    {
        public NameValuePair() { }
        public string Name { get { throw null; } set { } }
        public string Value { get { throw null; } set { } }
    }
    public partial class NetworkTrace
    {
        internal NetworkTrace() { }
        public string Message { get { throw null; } }
        public string Path { get { throw null; } }
        public string Status { get { throw null; } }
    }
    public partial class Nonce
    {
        public Nonce() { }
        public string NonceExpirationInterval { get { throw null; } set { } }
        public bool? ValidateNonce { get { throw null; } set { } }
    }
    public enum NotificationLevel
    {
        Critical = 0,
        Warning = 1,
        Information = 2,
        NonUrgentSuggestion = 3,
    }
    public partial class OpenIdConnectClientCredential
    {
        public OpenIdConnectClientCredential() { }
        public string ClientSecretSettingName { get { throw null; } set { } }
        public string Method { get { throw null; } set { } }
    }
    public partial class OpenIdConnectConfig
    {
        public OpenIdConnectConfig() { }
        public string AuthorizationEndpoint { get { throw null; } set { } }
        public System.Uri CertificationUri { get { throw null; } set { } }
        public string Issuer { get { throw null; } set { } }
        public string TokenEndpoint { get { throw null; } set { } }
        public string WellKnownOpenIdConfiguration { get { throw null; } set { } }
    }
    public partial class OpenIdConnectLogin
    {
        public OpenIdConnectLogin() { }
        public string NameClaimType { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> Scopes { get { throw null; } }
    }
    public partial class OpenIdConnectRegistration
    {
        public OpenIdConnectRegistration() { }
        public Azure.ResourceManager.AppService.Models.OpenIdConnectClientCredential ClientCredential { get { throw null; } set { } }
        public string ClientId { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.OpenIdConnectConfig OpenIdConnectConfiguration { get { throw null; } set { } }
    }
    public partial class OperationInformation
    {
        internal OperationInformation() { }
        public System.DateTimeOffset? CreatedTime { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppService.Models.ErrorEntity> Errors { get { throw null; } }
        public System.DateTimeOffset? ExpirationTime { get { throw null; } }
        public System.Guid? GeoMasterOperationId { get { throw null; } }
        public string Id { get { throw null; } }
        public System.DateTimeOffset? ModifiedTime { get { throw null; } }
        public string Name { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.OperationStatus? Status { get { throw null; } }
    }
    public enum OperationStatus
    {
        InProgress = 0,
        Failed = 1,
        Succeeded = 2,
        TimedOut = 3,
        Created = 4,
    }
    public partial class OperationStatusAutoGenerated
    {
        public OperationStatusAutoGenerated() { }
        public string Message { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.InsightStatus? StatusId { get { throw null; } set { } }
    }
    public partial class OutboundEnvironmentEndpoint
    {
        internal OutboundEnvironmentEndpoint() { }
        public string Category { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppService.Models.EndpointDependency> Endpoints { get { throw null; } }
    }
    public partial class PatchableAppServiceCertificateOrderData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public PatchableAppServiceCertificateOrderData() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppService.Models.AppServiceCertificateNotRenewableReason> AppServiceCertificateNotRenewableReasons { get { throw null; } }
        public bool? AutoRenew { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, Azure.ResourceManager.AppService.Models.AppServiceCertificate> Certificates { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.CertificateOrderContact Contact { get { throw null; } }
        public string Csr { get { throw null; } set { } }
        public string DistinguishedName { get { throw null; } set { } }
        public string DomainVerificationToken { get { throw null; } }
        public System.DateTimeOffset? ExpirationTime { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.CertificateDetails Intermediate { get { throw null; } }
        public bool? IsPrivateKeyExternal { get { throw null; } }
        public int? KeySize { get { throw null; } set { } }
        public System.DateTimeOffset? LastCertificateIssuanceTime { get { throw null; } }
        public System.DateTimeOffset? NextAutoRenewalTimeStamp { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.CertificateProductType? ProductType { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.CertificateDetails Root { get { throw null; } }
        public string SerialNumber { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.CertificateDetails SignedCertificate { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.CertificateOrderStatus? Status { get { throw null; } }
        public int? ValidityInYears { get { throw null; } set { } }
    }
    public partial class PatchableAppServiceCertificateResourceData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public PatchableAppServiceCertificateResourceData() { }
        public string KeyVaultId { get { throw null; } set { } }
        public string KeyVaultSecretName { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.KeyVaultSecretStatus? ProvisioningState { get { throw null; } }
    }
    public partial class PatchableAppServiceDomainData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public PatchableAppServiceDomainData() { }
        public string AuthCode { get { throw null; } set { } }
        public bool? AutoRenew { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.DomainPurchaseConsent Consent { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.ContactInformation ContactAdmin { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.ContactInformation ContactBilling { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.ContactInformation ContactRegistrant { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.ContactInformation ContactTech { get { throw null; } set { } }
        public System.DateTimeOffset? CreatedTime { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.DnsType? DnsType { get { throw null; } set { } }
        public string DnsZoneId { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppService.Models.DomainNotRenewableReasons> DomainNotRenewableReasons { get { throw null; } }
        public System.DateTimeOffset? ExpirationTime { get { throw null; } }
        public System.DateTimeOffset? LastRenewedTime { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppService.Models.HostName> ManagedHostNames { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> NameServers { get { throw null; } }
        public bool? Privacy { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public bool? ReadyForDnsRecordManagement { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.DomainStatus? RegistrationStatus { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.DnsType? TargetDnsType { get { throw null; } set { } }
    }
    public partial class PatchableAppServiceEnvironmentData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public PatchableAppServiceEnvironmentData() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.NameValuePair> ClusterSettings { get { throw null; } }
        public int? DedicatedHostCount { get { throw null; } set { } }
        public string DnsSuffix { get { throw null; } set { } }
        public int? FrontEndScaleFactor { get { throw null; } set { } }
        public bool? HasLinuxWorkers { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.LoadBalancingMode? InternalLoadBalancingMode { get { throw null; } set { } }
        public int? IpsslAddressCount { get { throw null; } set { } }
        public int? MaximumNumberOfMachines { get { throw null; } }
        public int? MultiRoleCount { get { throw null; } }
        public string MultiSize { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.HostingEnvironmentStatus? Status { get { throw null; } }
        public bool? Suspended { get { throw null; } }
        public System.Collections.Generic.IList<string> UserWhitelistedIpRanges { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.VirtualNetworkProfile VirtualNetwork { get { throw null; } set { } }
        public bool? ZoneRedundant { get { throw null; } set { } }
    }
    public partial class PatchableAppServicePlanData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public PatchableAppServicePlanData() { }
        public bool? ElasticScaleEnabled { get { throw null; } set { } }
        public System.DateTimeOffset? FreeOfferExpirationTime { get { throw null; } set { } }
        public string GeoRegion { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.HostingEnvironmentProfile HostingEnvironmentProfile { get { throw null; } set { } }
        public bool? HyperV { get { throw null; } set { } }
        public bool? IsSpot { get { throw null; } set { } }
        public bool? IsXenon { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.KubeEnvironmentProfile KubeEnvironmentProfile { get { throw null; } set { } }
        public int? MaximumElasticWorkerCount { get { throw null; } set { } }
        public int? MaximumNumberOfWorkers { get { throw null; } }
        public int? NumberOfSites { get { throw null; } }
        public bool? PerSiteScaling { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public bool? Reserved { get { throw null; } set { } }
        public string ResourceGroup { get { throw null; } }
        public System.DateTimeOffset? SpotExpirationTime { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.StatusOptions? Status { get { throw null; } }
        public string Subscription { get { throw null; } }
        public int? TargetWorkerCount { get { throw null; } set { } }
        public int? TargetWorkerSizeId { get { throw null; } set { } }
        public string WorkerTierName { get { throw null; } set { } }
        public bool? ZoneRedundant { get { throw null; } set { } }
    }
    public partial class PatchableCertificateData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public PatchableCertificateData() { }
        public string CanonicalName { get { throw null; } set { } }
        public byte[] CerBlob { get { throw null; } }
        public string DomainValidationMethod { get { throw null; } set { } }
        public System.DateTimeOffset? ExpirationDate { get { throw null; } }
        public string FriendlyName { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.HostingEnvironmentProfile HostingEnvironmentProfile { get { throw null; } }
        public System.Collections.Generic.IList<string> HostNames { get { throw null; } }
        public System.DateTimeOffset? IssueDate { get { throw null; } }
        public string Issuer { get { throw null; } }
        public string KeyVaultId { get { throw null; } set { } }
        public string KeyVaultSecretName { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.KeyVaultSecretStatus? KeyVaultSecretStatus { get { throw null; } }
        public string Password { get { throw null; } set { } }
        public byte[] PfxBlob { get { throw null; } set { } }
        public string PublicKeyHash { get { throw null; } }
        public string SelfLink { get { throw null; } }
        public string ServerFarmId { get { throw null; } set { } }
        public string SiteName { get { throw null; } }
        public string SubjectName { get { throw null; } }
        public string Thumbprint { get { throw null; } }
        public bool? Valid { get { throw null; } }
    }
    public partial class PatchableKubeEnvironmentData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public PatchableKubeEnvironmentData() { }
        public string AksResourceID { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.AppLogsConfiguration AppLogsConfiguration { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.ArcConfiguration ArcConfiguration { get { throw null; } set { } }
        public string DefaultDomain { get { throw null; } }
        public string DeploymentErrors { get { throw null; } }
        public bool? InternalLoadBalancerEnabled { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.KubeEnvironmentProvisioningState? ProvisioningState { get { throw null; } }
        public string StaticIp { get { throw null; } set { } }
    }
    public partial class PatchableStaticSiteARMResourceData : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public PatchableStaticSiteARMResourceData() { }
        public bool? AllowConfigFileUpdates { get { throw null; } set { } }
        public string Branch { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.StaticSiteBuildProperties BuildProperties { get { throw null; } set { } }
        public string ContentDistributionEndpoint { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> CustomDomains { get { throw null; } }
        public string DefaultHostname { get { throw null; } }
        public string KeyVaultReferenceIdentity { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppService.Models.ResponseMessageEnvelopeRemotePrivateEndpointConnection> PrivateEndpointConnections { get { throw null; } }
        public string Provider { get { throw null; } }
        public string RepositoryToken { get { throw null; } set { } }
        public string RepositoryUrl { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.StagingEnvironmentPolicy? StagingEnvironmentPolicy { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.StaticSiteTemplateOptions TemplateProperties { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppService.Models.StaticSiteUserProvidedFunctionApp> UserProvidedFunctionApps { get { throw null; } }
    }
    public partial class PerfMonResponse
    {
        internal PerfMonResponse() { }
        public string Code { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.PerfMonSet Data { get { throw null; } }
        public string Message { get { throw null; } }
    }
    public partial class PerfMonSample
    {
        internal PerfMonSample() { }
        public string InstanceName { get { throw null; } }
        public System.DateTimeOffset? Time { get { throw null; } }
        public double? Value { get { throw null; } }
    }
    public partial class PerfMonSet
    {
        internal PerfMonSet() { }
        public System.DateTimeOffset? EndTime { get { throw null; } }
        public string Name { get { throw null; } }
        public System.DateTimeOffset? StartTime { get { throw null; } }
        public string TimeGrain { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppService.Models.PerfMonSample> Values { get { throw null; } }
    }
    public partial class PremierAddOnOffer : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public PremierAddOnOffer() { }
        public string LegalTermsUrl { get { throw null; } set { } }
        public string MarketplaceOffer { get { throw null; } set { } }
        public string MarketplacePublisher { get { throw null; } set { } }
        public string PrivacyPolicyUrl { get { throw null; } set { } }
        public string Product { get { throw null; } set { } }
        public bool? PromoCodeRequired { get { throw null; } set { } }
        public int? Quota { get { throw null; } set { } }
        public string Sku { get { throw null; } set { } }
        public string Vendor { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.AppServicePlanRestrictions? WebHostingPlanRestrictions { get { throw null; } set { } }
    }
    public partial class PremierAddOnPatchResource : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public PremierAddOnPatchResource() { }
        public string MarketplaceOffer { get { throw null; } set { } }
        public string MarketplacePublisher { get { throw null; } set { } }
        public string Product { get { throw null; } set { } }
        public string Sku { get { throw null; } set { } }
        public string Vendor { get { throw null; } set { } }
    }
    public partial class PrivateAccessSubnet
    {
        public PrivateAccessSubnet() { }
        public int? Key { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
    }
    public partial class PrivateAccessVirtualNetwork
    {
        public PrivateAccessVirtualNetwork() { }
        public int? Key { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public string ResourceId { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.PrivateAccessSubnet> Subnets { get { throw null; } }
    }
    public partial class PrivateLinkConnectionApprovalRequestResource : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public PrivateLinkConnectionApprovalRequestResource() { }
        public Azure.ResourceManager.AppService.Models.PrivateLinkConnectionState PrivateLinkServiceConnectionState { get { throw null; } set { } }
    }
    public partial class PrivateLinkConnectionState
    {
        public PrivateLinkConnectionState() { }
        public string ActionsRequired { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public string Status { get { throw null; } set { } }
    }
    public partial class PrivateLinkResource : Azure.ResourceManager.Models.ResourceData
    {
        internal PrivateLinkResource() { }
        public Azure.ResourceManager.AppService.Models.PrivateLinkResourceProperties Properties { get { throw null; } }
    }
    public partial class PrivateLinkResourceProperties
    {
        internal PrivateLinkResourceProperties() { }
        public string GroupId { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> RequiredMembers { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> RequiredZoneNames { get { throw null; } }
    }
    public partial class ProcessThreadInfo : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public ProcessThreadInfo() { }
        public int? BasePriority { get { throw null; } set { } }
        public int? CurrentPriority { get { throw null; } set { } }
        public string Href { get { throw null; } set { } }
        public int? Identifier { get { throw null; } }
        public string PriorityLevel { get { throw null; } set { } }
        public string Process { get { throw null; } set { } }
        public string StartAddress { get { throw null; } set { } }
        public System.DateTimeOffset? StartTime { get { throw null; } set { } }
        public string State { get { throw null; } set { } }
        public string TotalProcessorTime { get { throw null; } set { } }
        public string UserProcessorTime { get { throw null; } set { } }
        public string WaitReason { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ProviderOsTypeSelected : System.IEquatable<Azure.ResourceManager.AppService.Models.ProviderOsTypeSelected>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ProviderOsTypeSelected(string value) { throw null; }
        public static Azure.ResourceManager.AppService.Models.ProviderOsTypeSelected All { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.ProviderOsTypeSelected Linux { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.ProviderOsTypeSelected LinuxFunctions { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.ProviderOsTypeSelected Windows { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.ProviderOsTypeSelected WindowsFunctions { get { throw null; } }
        public bool Equals(Azure.ResourceManager.AppService.Models.ProviderOsTypeSelected other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.AppService.Models.ProviderOsTypeSelected left, Azure.ResourceManager.AppService.Models.ProviderOsTypeSelected right) { throw null; }
        public static implicit operator Azure.ResourceManager.AppService.Models.ProviderOsTypeSelected (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.AppService.Models.ProviderOsTypeSelected left, Azure.ResourceManager.AppService.Models.ProviderOsTypeSelected right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ProviderStackOsType : System.IEquatable<Azure.ResourceManager.AppService.Models.ProviderStackOsType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ProviderStackOsType(string value) { throw null; }
        public static Azure.ResourceManager.AppService.Models.ProviderStackOsType All { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.ProviderStackOsType Linux { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.ProviderStackOsType Windows { get { throw null; } }
        public bool Equals(Azure.ResourceManager.AppService.Models.ProviderStackOsType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.AppService.Models.ProviderStackOsType left, Azure.ResourceManager.AppService.Models.ProviderStackOsType right) { throw null; }
        public static implicit operator Azure.ResourceManager.AppService.Models.ProviderStackOsType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.AppService.Models.ProviderStackOsType left, Azure.ResourceManager.AppService.Models.ProviderStackOsType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public enum ProvisioningState
    {
        Succeeded = 0,
        Failed = 1,
        Canceled = 2,
        InProgress = 3,
        Deleting = 4,
    }
    public partial class ProxyOnlyResource : Azure.ResourceManager.Models.ResourceData
    {
        public ProxyOnlyResource() { }
        public string Kind { get { throw null; } set { } }
    }
    public enum PublicCertificateLocation
    {
        Unknown = 0,
        CurrentUserMy = 1,
        LocalMachineMy = 2,
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PublishingProfileFormat : System.IEquatable<Azure.ResourceManager.AppService.Models.PublishingProfileFormat>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PublishingProfileFormat(string value) { throw null; }
        public static Azure.ResourceManager.AppService.Models.PublishingProfileFormat FileZilla3 { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.PublishingProfileFormat Ftp { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.PublishingProfileFormat WebDeploy { get { throw null; } }
        public bool Equals(Azure.ResourceManager.AppService.Models.PublishingProfileFormat other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.AppService.Models.PublishingProfileFormat left, Azure.ResourceManager.AppService.Models.PublishingProfileFormat right) { throw null; }
        public static implicit operator Azure.ResourceManager.AppService.Models.PublishingProfileFormat (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.AppService.Models.PublishingProfileFormat left, Azure.ResourceManager.AppService.Models.PublishingProfileFormat right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class PushSettings : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public PushSettings() { }
        public string DynamicTagsJson { get { throw null; } set { } }
        public bool? IsPushEnabled { get { throw null; } set { } }
        public string TagsRequiringAuth { get { throw null; } set { } }
        public string TagWhitelistJson { get { throw null; } set { } }
    }
    public partial class QueryUtterancesResult
    {
        public QueryUtterancesResult() { }
        public Azure.ResourceManager.AppService.Models.SampleUtterance SampleUtterance { get { throw null; } set { } }
        public float? Score { get { throw null; } set { } }
    }
    public partial class QueryUtterancesResults
    {
        public QueryUtterancesResults() { }
        public string Query { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.QueryUtterancesResult> Results { get { throw null; } }
    }
    public partial class RampUpRule
    {
        public RampUpRule() { }
        public string ActionHostName { get { throw null; } set { } }
        public string ChangeDecisionCallbackUrl { get { throw null; } set { } }
        public int? ChangeIntervalInMinutes { get { throw null; } set { } }
        public double? ChangeStep { get { throw null; } set { } }
        public double? MaxReroutePercentage { get { throw null; } set { } }
        public double? MinReroutePercentage { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public double? ReroutePercentage { get { throw null; } set { } }
    }
    public enum RedundancyMode
    {
        None = 0,
        Manual = 1,
        Failover = 2,
        ActiveActive = 3,
        GeoRedundant = 4,
    }
    public partial class ReissueCertificateOrderRequest : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public ReissueCertificateOrderRequest() { }
        public string Csr { get { throw null; } set { } }
        public int? DelayExistingRevokeInHours { get { throw null; } set { } }
        public bool? IsPrivateKeyExternal { get { throw null; } set { } }
        public int? KeySize { get { throw null; } set { } }
    }
    public partial class RemotePrivateEndpointConnection : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public RemotePrivateEndpointConnection() { }
        public System.Collections.Generic.IList<string> IpAddresses { get { throw null; } }
        public Azure.Core.ResourceIdentifier PrivateEndpointId { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.PrivateLinkConnectionState PrivateLinkServiceConnectionState { get { throw null; } set { } }
        public string ProvisioningState { get { throw null; } }
    }
    public partial class Rendering
    {
        public Rendering() { }
        public string Description { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.RenderingType? RenderingType { get { throw null; } set { } }
        public string Title { get { throw null; } set { } }
    }
    public enum RenderingType
    {
        NoGraph = 0,
        Table = 1,
        TimeSeries = 2,
        TimeSeriesPerInstance = 3,
        PieChart = 4,
        DataSummary = 5,
        Email = 6,
        Insights = 7,
        DynamicInsight = 8,
        Markdown = 9,
        Detector = 10,
        DropDown = 11,
        Card = 12,
        Solution = 13,
        Guage = 14,
        Form = 15,
        ChangeSets = 16,
        ChangeAnalysisOnboarding = 17,
        ChangesView = 18,
        AppInsight = 19,
        DependencyGraph = 20,
        DownTime = 21,
        SummaryCard = 22,
        SearchComponent = 23,
        AppInsightEnablement = 24,
    }
    public partial class RenewCertificateOrderRequest : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public RenewCertificateOrderRequest() { }
        public string Csr { get { throw null; } set { } }
        public bool? IsPrivateKeyExternal { get { throw null; } set { } }
        public int? KeySize { get { throw null; } set { } }
    }
    public partial class RequestsBasedTrigger
    {
        public RequestsBasedTrigger() { }
        public int? Count { get { throw null; } set { } }
        public string TimeInterval { get { throw null; } set { } }
    }
    public enum ResolveStatus
    {
        Initialized = 0,
        Resolved = 1,
        InvalidSyntax = 2,
        MSINotEnabled = 3,
        VaultNotFound = 4,
        SecretNotFound = 5,
        SecretVersionNotFound = 6,
        AccessToKeyVaultDenied = 7,
        OtherReasons = 8,
        FetchTimedOut = 9,
        UnauthorizedClient = 10,
    }
    public partial class ResourceMetricAvailability
    {
        internal ResourceMetricAvailability() { }
        public string Retention { get { throw null; } }
        public string TimeGrain { get { throw null; } }
    }
    public partial class ResourceMetricDefinition : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public ResourceMetricDefinition() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppService.Models.ResourceMetricAvailability> MetricAvailabilities { get { throw null; } }
        public string PrimaryAggregationType { get { throw null; } }
        public System.Collections.Generic.IReadOnlyDictionary<string, string> Properties { get { throw null; } }
        public System.Uri ResourceUri { get { throw null; } }
        public string Unit { get { throw null; } }
    }
    public partial class ResourceNameAvailability
    {
        internal ResourceNameAvailability() { }
        public string Message { get { throw null; } }
        public bool? NameAvailable { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.InAvailabilityReasonType? Reason { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ResourceScopeType : System.IEquatable<Azure.ResourceManager.AppService.Models.ResourceScopeType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ResourceScopeType(string value) { throw null; }
        public static Azure.ResourceManager.AppService.Models.ResourceScopeType ServerFarm { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.ResourceScopeType Subscription { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.ResourceScopeType WebSite { get { throw null; } }
        public bool Equals(Azure.ResourceManager.AppService.Models.ResourceScopeType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.AppService.Models.ResourceScopeType left, Azure.ResourceManager.AppService.Models.ResourceScopeType right) { throw null; }
        public static implicit operator Azure.ResourceManager.AppService.Models.ResourceScopeType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.AppService.Models.ResourceScopeType left, Azure.ResourceManager.AppService.Models.ResourceScopeType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ResponseMessageEnvelopeRemotePrivateEndpointConnection : Azure.ResourceManager.Models.ResourceData
    {
        internal ResponseMessageEnvelopeRemotePrivateEndpointConnection() { }
        public Azure.ResourceManager.AppService.Models.ErrorEntity Error { get { throw null; } }
        public Azure.ResourceManager.Models.ManagedServiceIdentity Identity { get { throw null; } }
        public string Location { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.ArmPlan Plan { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.RemotePrivateEndpointConnection Properties { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.SkuDescription Sku { get { throw null; } }
        public string Status { get { throw null; } }
        public System.Collections.Generic.IReadOnlyDictionary<string, string> Tags { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> Zones { get { throw null; } }
    }
    public partial class RestoreRequest : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public RestoreRequest() { }
        public bool? AdjustConnectionStrings { get { throw null; } set { } }
        public string AppServicePlan { get { throw null; } set { } }
        public string BlobName { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.DatabaseBackupSetting> Databases { get { throw null; } }
        public string HostingEnvironment { get { throw null; } set { } }
        public bool? IgnoreConflictingHostNames { get { throw null; } set { } }
        public bool? IgnoreDatabases { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.BackupRestoreOperationType? OperationType { get { throw null; } set { } }
        public bool? Overwrite { get { throw null; } set { } }
        public string SiteName { get { throw null; } set { } }
        public string StorageAccountUrl { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct RouteType : System.IEquatable<Azure.ResourceManager.AppService.Models.RouteType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public RouteType(string value) { throw null; }
        public static Azure.ResourceManager.AppService.Models.RouteType Default { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.RouteType Inherited { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.RouteType Static { get { throw null; } }
        public bool Equals(Azure.ResourceManager.AppService.Models.RouteType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.AppService.Models.RouteType left, Azure.ResourceManager.AppService.Models.RouteType right) { throw null; }
        public static implicit operator Azure.ResourceManager.AppService.Models.RouteType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.AppService.Models.RouteType left, Azure.ResourceManager.AppService.Models.RouteType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SampleUtterance
    {
        public SampleUtterance() { }
        public System.Collections.Generic.IList<string> Links { get { throw null; } }
        public string Qid { get { throw null; } set { } }
        public string Text { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ScmType : System.IEquatable<Azure.ResourceManager.AppService.Models.ScmType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ScmType(string value) { throw null; }
        public static Azure.ResourceManager.AppService.Models.ScmType BitbucketGit { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.ScmType BitbucketHg { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.ScmType CodePlexGit { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.ScmType CodePlexHg { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.ScmType Dropbox { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.ScmType ExternalGit { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.ScmType ExternalHg { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.ScmType GitHub { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.ScmType LocalGit { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.ScmType None { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.ScmType OneDrive { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.ScmType Tfs { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.ScmType VSO { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.ScmType Vstsrm { get { throw null; } }
        public bool Equals(Azure.ResourceManager.AppService.Models.ScmType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.AppService.Models.ScmType left, Azure.ResourceManager.AppService.Models.ScmType right) { throw null; }
        public static implicit operator Azure.ResourceManager.AppService.Models.ScmType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.AppService.Models.ScmType left, Azure.ResourceManager.AppService.Models.ScmType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ServiceSpecification
    {
        internal ServiceSpecification() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppService.Models.LogSpecification> LogSpecifications { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppService.Models.MetricSpecification> MetricSpecifications { get { throw null; } }
    }
    public partial class SiteAuthSettings : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public SiteAuthSettings() { }
        public string AadClaimsAuthorization { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> AdditionalLoginParams { get { throw null; } }
        public System.Collections.Generic.IList<string> AllowedAudiences { get { throw null; } }
        public System.Collections.Generic.IList<string> AllowedExternalRedirectUrls { get { throw null; } }
        public string AuthFilePath { get { throw null; } set { } }
        public string ClientId { get { throw null; } set { } }
        public string ClientSecret { get { throw null; } set { } }
        public string ClientSecretCertificateThumbprint { get { throw null; } set { } }
        public string ClientSecretSettingName { get { throw null; } set { } }
        public string ConfigVersion { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.BuiltInAuthenticationProvider? DefaultProvider { get { throw null; } set { } }
        public bool? Enabled { get { throw null; } set { } }
        public string FacebookAppId { get { throw null; } set { } }
        public string FacebookAppSecret { get { throw null; } set { } }
        public string FacebookAppSecretSettingName { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> FacebookOAuthScopes { get { throw null; } }
        public string GitHubClientId { get { throw null; } set { } }
        public string GitHubClientSecret { get { throw null; } set { } }
        public string GitHubClientSecretSettingName { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> GitHubOAuthScopes { get { throw null; } }
        public string GoogleClientId { get { throw null; } set { } }
        public string GoogleClientSecret { get { throw null; } set { } }
        public string GoogleClientSecretSettingName { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> GoogleOAuthScopes { get { throw null; } }
        public string IsAuthFromFile { get { throw null; } set { } }
        public string Issuer { get { throw null; } set { } }
        public string MicrosoftAccountClientId { get { throw null; } set { } }
        public string MicrosoftAccountClientSecret { get { throw null; } set { } }
        public string MicrosoftAccountClientSecretSettingName { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> MicrosoftAccountOAuthScopes { get { throw null; } }
        public string RuntimeVersion { get { throw null; } set { } }
        public double? TokenRefreshExtensionHours { get { throw null; } set { } }
        public bool? TokenStoreEnabled { get { throw null; } set { } }
        public string TwitterConsumerKey { get { throw null; } set { } }
        public string TwitterConsumerSecret { get { throw null; } set { } }
        public string TwitterConsumerSecretSettingName { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.UnauthenticatedClientAction? UnauthenticatedClientAction { get { throw null; } set { } }
        public bool? ValidateIssuer { get { throw null; } set { } }
    }
    public partial class SiteAuthSettingsV2 : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public SiteAuthSettingsV2() { }
        public Azure.ResourceManager.AppService.Models.GlobalValidation GlobalValidation { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.HttpSettings HttpSettings { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.IdentityProviders IdentityProviders { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.LoginInformation Login { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.AuthPlatform Platform { get { throw null; } set { } }
    }
    public enum SiteAvailabilityState
    {
        Normal = 0,
        Limited = 1,
        DisasterRecoveryMode = 2,
    }
    public partial class SiteCloneability
    {
        internal SiteCloneability() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppService.Models.SiteCloneabilityCriterion> BlockingCharacteristics { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppService.Models.SiteCloneabilityCriterion> BlockingFeatures { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.CloneAbilityResult? Result { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppService.Models.SiteCloneabilityCriterion> UnsupportedFeatures { get { throw null; } }
    }
    public partial class SiteCloneabilityCriterion
    {
        internal SiteCloneabilityCriterion() { }
        public string Description { get { throw null; } }
        public string Name { get { throw null; } }
    }
    public partial class SiteConfigProperties
    {
        public SiteConfigProperties() { }
        public bool? AcrUseManagedIdentityCreds { get { throw null; } set { } }
        public string AcrUserManagedIdentityID { get { throw null; } set { } }
        public bool? AlwaysOn { get { throw null; } set { } }
        public string ApiDefinitionUrl { get { throw null; } set { } }
        public string ApiManagementConfigId { get { throw null; } set { } }
        public string AppCommandLine { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.NameValuePair> AppSettings { get { throw null; } set { } }
        public bool? AutoHealEnabled { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.AutoHealRules AutoHealRules { get { throw null; } set { } }
        public string AutoSwapSlotName { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, Azure.ResourceManager.AppService.Models.AzureStorageInfoValue> AzureStorageAccounts { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.ConnStringInfo> ConnectionStrings { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.CorsSettings Cors { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> DefaultDocuments { get { throw null; } set { } }
        public bool? DetailedErrorLoggingEnabled { get { throw null; } set { } }
        public string DocumentRoot { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.RampUpRule> ExperimentsRampUpRules { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.FtpsState? FtpsState { get { throw null; } set { } }
        public int? FunctionAppScaleLimit { get { throw null; } set { } }
        public bool? FunctionsRuntimeScaleMonitoringEnabled { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.HandlerMapping> HandlerMappings { get { throw null; } set { } }
        public string HealthCheckPath { get { throw null; } set { } }
        public bool? Http20Enabled { get { throw null; } set { } }
        public bool? HttpLoggingEnabled { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.IpSecurityRestriction> IpSecurityRestrictions { get { throw null; } set { } }
        public string JavaContainer { get { throw null; } set { } }
        public string JavaContainerVersion { get { throw null; } set { } }
        public string JavaVersion { get { throw null; } set { } }
        public string KeyVaultReferenceIdentity { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.SiteLimits Limits { get { throw null; } set { } }
        public string LinuxFxVersion { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.SiteLoadBalancing? LoadBalancing { get { throw null; } set { } }
        public bool? LocalMySqlEnabled { get { throw null; } set { } }
        public int? LogsDirectorySizeLimit { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.SiteMachineKey MachineKey { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.ManagedPipelineMode? ManagedPipelineMode { get { throw null; } set { } }
        public int? ManagedServiceIdentityId { get { throw null; } set { } }
        public int? MinimumElasticInstanceCount { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.SupportedTlsVersions? MinTlsVersion { get { throw null; } set { } }
        public string NetFrameworkVersion { get { throw null; } set { } }
        public string NodeVersion { get { throw null; } set { } }
        public int? NumberOfWorkers { get { throw null; } set { } }
        public string PhpVersion { get { throw null; } set { } }
        public string PowerShellVersion { get { throw null; } set { } }
        public int? PreWarmedInstanceCount { get { throw null; } set { } }
        public string PublicNetworkAccess { get { throw null; } set { } }
        public string PublishingUsername { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.PushSettings Push { get { throw null; } set { } }
        public string PythonVersion { get { throw null; } set { } }
        public bool? RemoteDebuggingEnabled { get { throw null; } set { } }
        public string RemoteDebuggingVersion { get { throw null; } set { } }
        public bool? RequestTracingEnabled { get { throw null; } set { } }
        public System.DateTimeOffset? RequestTracingExpirationTime { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.IpSecurityRestriction> ScmIpSecurityRestrictions { get { throw null; } set { } }
        public bool? ScmIpSecurityRestrictionsUseMain { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.SupportedTlsVersions? ScmMinTlsVersion { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.ScmType? ScmType { get { throw null; } set { } }
        public string TracingOptions { get { throw null; } set { } }
        public bool? Use32BitWorkerProcess { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.VirtualApplication> VirtualApplications { get { throw null; } set { } }
        public string VnetName { get { throw null; } set { } }
        public int? VnetPrivatePortsCount { get { throw null; } set { } }
        public bool? VnetRouteAllEnabled { get { throw null; } set { } }
        public string WebsiteTimeZone { get { throw null; } set { } }
        public bool? WebSocketsEnabled { get { throw null; } set { } }
        public string WindowsFxVersion { get { throw null; } set { } }
        public int? XManagedServiceIdentityId { get { throw null; } set { } }
    }
    public partial class SiteConfigPropertiesDictionary
    {
        internal SiteConfigPropertiesDictionary() { }
        public string JavaVersion { get { throw null; } }
        public string LinuxFxVersion { get { throw null; } }
        public string PowerShellVersion { get { throw null; } }
        public bool? Use32BitWorkerProcess { get { throw null; } }
    }
    public partial class SiteConfigurationSnapshotInfo : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public SiteConfigurationSnapshotInfo() { }
        public int? SnapshotId { get { throw null; } }
        public System.DateTimeOffset? Time { get { throw null; } }
    }
    public enum SiteExtensionType
    {
        Gallery = 0,
        WebRoot = 1,
    }
    public partial class SiteLimits
    {
        public SiteLimits() { }
        public long? MaxDiskSizeInMb { get { throw null; } set { } }
        public long? MaxMemoryInMb { get { throw null; } set { } }
        public double? MaxPercentageCpu { get { throw null; } set { } }
    }
    public enum SiteLoadBalancing
    {
        WeightedRoundRobin = 0,
        LeastRequests = 1,
        LeastResponseTime = 2,
        WeightedTotalTraffic = 3,
        RequestHash = 4,
        PerSiteRoundRobin = 5,
    }
    public partial class SiteMachineKey
    {
        internal SiteMachineKey() { }
        public string Decryption { get { throw null; } }
        public string DecryptionKey { get { throw null; } }
        public string Validation { get { throw null; } }
        public string ValidationKey { get { throw null; } }
    }
    public partial class SitePatchResource : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public SitePatchResource() { }
        public Azure.ResourceManager.AppService.Models.SiteAvailabilityState? AvailabilityState { get { throw null; } }
        public bool? ClientAffinityEnabled { get { throw null; } set { } }
        public bool? ClientCertEnabled { get { throw null; } set { } }
        public string ClientCertExclusionPaths { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.ClientCertMode? ClientCertMode { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.CloningInfo CloningInfo { get { throw null; } set { } }
        public int? ContainerSize { get { throw null; } set { } }
        public string CustomDomainVerificationId { get { throw null; } set { } }
        public int? DailyMemoryTimeQuota { get { throw null; } set { } }
        public string DefaultHostName { get { throw null; } }
        public bool? Enabled { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<string> EnabledHostNames { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.HostingEnvironmentProfile HostingEnvironmentProfile { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<string> HostNames { get { throw null; } }
        public bool? HostNamesDisabled { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.HostNameSslState> HostNameSslStates { get { throw null; } }
        public bool? HttpsOnly { get { throw null; } set { } }
        public bool? HyperV { get { throw null; } set { } }
        public Azure.ResourceManager.Models.ManagedServiceIdentity Identity { get { throw null; } set { } }
        public System.Guid? InProgressOperationId { get { throw null; } }
        public bool? IsDefaultContainer { get { throw null; } }
        public bool? IsXenon { get { throw null; } set { } }
        public string KeyVaultReferenceIdentity { get { throw null; } set { } }
        public System.DateTimeOffset? LastModifiedTimeUtc { get { throw null; } }
        public int? MaxNumberOfWorkers { get { throw null; } }
        public string OutboundIpAddresses { get { throw null; } }
        public string PossibleOutboundIpAddresses { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.RedundancyMode? RedundancyMode { get { throw null; } set { } }
        public string RepositorySiteName { get { throw null; } }
        public bool? Reserved { get { throw null; } set { } }
        public string ResourceGroup { get { throw null; } }
        public bool? ScmSiteAlsoStopped { get { throw null; } set { } }
        public string ServerFarmId { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.SiteConfigProperties SiteConfig { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.SlotSwapStatus SlotSwapStatus { get { throw null; } }
        public string State { get { throw null; } }
        public bool? StorageAccountRequired { get { throw null; } set { } }
        public System.DateTimeOffset? SuspendedTill { get { throw null; } }
        public string TargetSwapSlot { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> TrafficManagerHostNames { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.UsageState? UsageState { get { throw null; } }
        public string VirtualNetworkSubnetId { get { throw null; } set { } }
    }
    public partial class SitePhpErrorLogFlag : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public SitePhpErrorLogFlag() { }
        public string LocalLogErrors { get { throw null; } set { } }
        public string LocalLogErrorsMaxLength { get { throw null; } set { } }
        public string MasterLogErrors { get { throw null; } set { } }
        public string MasterLogErrorsMaxLength { get { throw null; } set { } }
    }
    public enum SiteRuntimeState
    {
        Unknown = 0,
        Ready = 1,
        Stopped = 2,
    }
    public partial class SiteSeal
    {
        internal SiteSeal() { }
        public string Html { get { throw null; } }
    }
    public partial class SiteSealRequest
    {
        public SiteSealRequest() { }
        public bool? LightTheme { get { throw null; } set { } }
        public string Locale { get { throw null; } set { } }
    }
    public partial class SkuCapacity
    {
        public SkuCapacity() { }
        public int? Default { get { throw null; } set { } }
        public int? ElasticMaximum { get { throw null; } set { } }
        public int? Maximum { get { throw null; } set { } }
        public int? Minimum { get { throw null; } set { } }
        public string ScaleType { get { throw null; } set { } }
    }
    public partial class SkuDescription
    {
        public SkuDescription() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.Capability> Capabilities { get { throw null; } }
        public int? Capacity { get { throw null; } set { } }
        public string Family { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> Locations { get { throw null; } }
        public string Name { get { throw null; } set { } }
        public string Size { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.SkuCapacity SkuCapacity { get { throw null; } set { } }
        public string Tier { get { throw null; } set { } }
    }
    public partial class SkuInfo
    {
        internal SkuInfo() { }
        public Azure.ResourceManager.AppService.Models.SkuCapacity Capacity { get { throw null; } }
        public string ResourceType { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.SkuDescription Sku { get { throw null; } }
    }
    public partial class SkuInfos
    {
        internal SkuInfos() { }
        public string ResourceType { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppService.Models.GlobalCsmSkuDescription> Skus { get { throw null; } }
    }
    public partial class SlotDifference : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public SlotDifference() { }
        public string Description { get { throw null; } }
        public string DiffRule { get { throw null; } }
        public string Level { get { throw null; } }
        public string SettingName { get { throw null; } }
        public string SettingType { get { throw null; } }
        public string ValueInCurrentSlot { get { throw null; } }
        public string ValueInTargetSlot { get { throw null; } }
    }
    public partial class SlotSwapStatus
    {
        internal SlotSwapStatus() { }
        public string DestinationSlotName { get { throw null; } }
        public string SourceSlotName { get { throw null; } }
        public System.DateTimeOffset? TimestampUtc { get { throw null; } }
    }
    public partial class SlowRequestsBasedTrigger
    {
        public SlowRequestsBasedTrigger() { }
        public int? Count { get { throw null; } set { } }
        public string Path { get { throw null; } set { } }
        public string TimeInterval { get { throw null; } set { } }
        public string TimeTaken { get { throw null; } set { } }
    }
    public partial class Snapshot : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public Snapshot() { }
        public string Time { get { throw null; } }
    }
    public partial class SnapshotRecoverySource
    {
        public SnapshotRecoverySource() { }
        public string Id { get { throw null; } set { } }
        public string Location { get { throw null; } set { } }
    }
    public partial class SnapshotRestoreRequest : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public SnapshotRestoreRequest() { }
        public bool? IgnoreConflictingHostNames { get { throw null; } set { } }
        public bool? Overwrite { get { throw null; } set { } }
        public bool? RecoverConfiguration { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.SnapshotRecoverySource RecoverySource { get { throw null; } set { } }
        public string SnapshotTime { get { throw null; } set { } }
        public bool? UseDRSecondary { get { throw null; } set { } }
    }
    public partial class Solution
    {
        public Solution() { }
        public System.Collections.Generic.IList<System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.NameValuePair>> Data { get { throw null; } }
        public string Description { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public double? Id { get { throw null; } set { } }
        public System.Collections.Generic.IList<System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.NameValuePair>> Metadata { get { throw null; } }
        public double? Order { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.SolutionType? SolutionType { get { throw null; } set { } }
    }
    public enum SolutionType
    {
        QuickSolution = 0,
        DeepInvestigation = 1,
        BestPractices = 2,
    }
    public enum SslState
    {
        Disabled = 0,
        SniEnabled = 1,
        IpBasedEnabled = 2,
    }
    public partial class StackMajorVersion
    {
        public StackMajorVersion() { }
        public bool? ApplicationInsights { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, System.BinaryData> AppSettingsDictionary { get { throw null; } }
        public string DisplayVersion { get { throw null; } set { } }
        public bool? IsDefault { get { throw null; } set { } }
        public bool? IsDeprecated { get { throw null; } set { } }
        public bool? IsHidden { get { throw null; } set { } }
        public bool? IsPreview { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.StackMinorVersion> MinorVersions { get { throw null; } }
        public string RuntimeVersion { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, System.BinaryData> SiteConfigPropertiesDictionary { get { throw null; } }
    }
    public partial class StackMinorVersion
    {
        public StackMinorVersion() { }
        public string DisplayVersion { get { throw null; } set { } }
        public bool? IsDefault { get { throw null; } set { } }
        public bool? IsRemoteDebuggingEnabled { get { throw null; } set { } }
        public string RuntimeVersion { get { throw null; } set { } }
    }
    public enum StackPreferredOs
    {
        Windows = 0,
        Linux = 1,
    }
    public enum StagingEnvironmentPolicy
    {
        Enabled = 0,
        Disabled = 1,
    }
    public partial class StampCapacity
    {
        internal StampCapacity() { }
        public long? AvailableCapacity { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.ComputeModeOptions? ComputeMode { get { throw null; } }
        public bool? ExcludeFromCapacityAllocation { get { throw null; } }
        public bool? IsApplicableForAllComputeModes { get { throw null; } }
        public bool? IsLinux { get { throw null; } }
        public string Name { get { throw null; } }
        public string SiteMode { get { throw null; } }
        public long? TotalCapacity { get { throw null; } }
        public string Unit { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.WorkerSizeOptions? WorkerSize { get { throw null; } }
        public int? WorkerSizeId { get { throw null; } }
    }
    public partial class StaticSiteBuildProperties
    {
        public StaticSiteBuildProperties() { }
        public string ApiBuildCommand { get { throw null; } set { } }
        public string ApiLocation { get { throw null; } set { } }
        public string AppArtifactLocation { get { throw null; } set { } }
        public string AppBuildCommand { get { throw null; } set { } }
        public string AppLocation { get { throw null; } set { } }
        public string GithubActionSecretNameOverride { get { throw null; } set { } }
        public string OutputLocation { get { throw null; } set { } }
        public bool? SkipGithubActionWorkflowGeneration { get { throw null; } set { } }
    }
    public partial class StaticSiteCustomDomainRequestPropertiesARMResource : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public StaticSiteCustomDomainRequestPropertiesARMResource() { }
        public string ValidationMethod { get { throw null; } set { } }
    }
    public partial class StaticSiteFunctionOverviewARMResource : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public StaticSiteFunctionOverviewARMResource() { }
        public string FunctionName { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.TriggerTypes? TriggerType { get { throw null; } }
    }
    public partial class StaticSiteResetPropertiesARMResource : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public StaticSiteResetPropertiesARMResource() { }
        public string RepositoryToken { get { throw null; } set { } }
        public bool? ShouldUpdateRepository { get { throw null; } set { } }
    }
    public partial class StaticSitesWorkflowPreview : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public StaticSitesWorkflowPreview() { }
        public string Contents { get { throw null; } }
        public string Path { get { throw null; } }
    }
    public partial class StaticSitesWorkflowPreviewRequest : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public StaticSitesWorkflowPreviewRequest() { }
        public string Branch { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.StaticSiteBuildProperties BuildProperties { get { throw null; } set { } }
        public string RepositoryUrl { get { throw null; } set { } }
    }
    public partial class StaticSiteTemplateOptions
    {
        public StaticSiteTemplateOptions() { }
        public string Description { get { throw null; } set { } }
        public bool? IsPrivate { get { throw null; } set { } }
        public string Owner { get { throw null; } set { } }
        public string RepositoryName { get { throw null; } set { } }
        public string TemplateRepositoryUrl { get { throw null; } set { } }
    }
    public partial class StaticSiteUserARMResource : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public StaticSiteUserARMResource() { }
        public string DisplayName { get { throw null; } }
        public string Provider { get { throw null; } }
        public string Roles { get { throw null; } set { } }
        public string UserId { get { throw null; } }
    }
    public partial class StaticSiteUserInvitationRequestResource : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public StaticSiteUserInvitationRequestResource() { }
        public string Domain { get { throw null; } set { } }
        public int? NumHoursToExpiration { get { throw null; } set { } }
        public string Provider { get { throw null; } set { } }
        public string Roles { get { throw null; } set { } }
        public string UserDetails { get { throw null; } set { } }
    }
    public partial class StaticSiteUserInvitationResponseResource : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public StaticSiteUserInvitationResponseResource() { }
        public System.DateTimeOffset? ExpiresOn { get { throw null; } }
        public string InvitationUrl { get { throw null; } }
    }
    public partial class StaticSiteUserProvidedFunctionApp : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public StaticSiteUserProvidedFunctionApp() { }
        public System.DateTimeOffset? CreatedOn { get { throw null; } }
        public string FunctionAppRegion { get { throw null; } set { } }
        public string FunctionAppResourceId { get { throw null; } set { } }
    }
    public partial class StaticSiteZipDeploymentARMResource : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public StaticSiteZipDeploymentARMResource() { }
        public string ApiZipUrl { get { throw null; } set { } }
        public string AppZipUrl { get { throw null; } set { } }
        public string DeploymentTitle { get { throw null; } set { } }
        public string FunctionLanguage { get { throw null; } set { } }
        public string Provider { get { throw null; } set { } }
    }
    public partial class StatusCodesBasedTrigger
    {
        public StatusCodesBasedTrigger() { }
        public int? Count { get { throw null; } set { } }
        public string Path { get { throw null; } set { } }
        public int? Status { get { throw null; } set { } }
        public int? SubStatus { get { throw null; } set { } }
        public string TimeInterval { get { throw null; } set { } }
        public int? Win32Status { get { throw null; } set { } }
    }
    public partial class StatusCodesRangeBasedTrigger
    {
        public StatusCodesRangeBasedTrigger() { }
        public int? Count { get { throw null; } set { } }
        public string Path { get { throw null; } set { } }
        public string StatusCodes { get { throw null; } set { } }
        public string TimeInterval { get { throw null; } set { } }
    }
    public enum StatusOptions
    {
        Ready = 0,
        Pending = 1,
        Creating = 2,
    }
    public partial class StorageMigrationOptions : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public StorageMigrationOptions() { }
        public string AzurefilesConnectionString { get { throw null; } set { } }
        public string AzurefilesShare { get { throw null; } set { } }
        public bool? BlockWriteAccessToSite { get { throw null; } set { } }
        public bool? SwitchSiteAfterMigration { get { throw null; } set { } }
    }
    public partial class StorageMigrationResponse : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public StorageMigrationResponse() { }
        public string OperationId { get { throw null; } }
    }
    public enum StorageType
    {
        LocalNode = 0,
        NetworkFileSystem = 1,
    }
    public partial class StringDictionary : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public StringDictionary() { }
        public System.Collections.Generic.IDictionary<string, string> Properties { get { throw null; } }
    }
    public partial class StringList : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public StringList() { }
        public System.Collections.Generic.IList<string> Properties { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SupportedTlsVersions : System.IEquatable<Azure.ResourceManager.AppService.Models.SupportedTlsVersions>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SupportedTlsVersions(string value) { throw null; }
        public static Azure.ResourceManager.AppService.Models.SupportedTlsVersions One0 { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.SupportedTlsVersions One1 { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.SupportedTlsVersions One2 { get { throw null; } }
        public bool Equals(Azure.ResourceManager.AppService.Models.SupportedTlsVersions other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.AppService.Models.SupportedTlsVersions left, Azure.ResourceManager.AppService.Models.SupportedTlsVersions right) { throw null; }
        public static implicit operator Azure.ResourceManager.AppService.Models.SupportedTlsVersions (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.AppService.Models.SupportedTlsVersions left, Azure.ResourceManager.AppService.Models.SupportedTlsVersions right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SupportTopic
    {
        internal SupportTopic() { }
        public string Id { get { throw null; } }
        public string PesId { get { throw null; } }
    }
    public partial class TldLegalAgreement
    {
        internal TldLegalAgreement() { }
        public string AgreementKey { get { throw null; } }
        public string Content { get { throw null; } }
        public string Title { get { throw null; } }
        public string Url { get { throw null; } }
    }
    public partial class TokenStore
    {
        public TokenStore() { }
        public string AzureBlobStorageSasUrlSettingName { get { throw null; } set { } }
        public bool? Enabled { get { throw null; } set { } }
        public string FileSystemDirectory { get { throw null; } set { } }
        public double? TokenRefreshExtensionHours { get { throw null; } set { } }
    }
    public partial class TopLevelDomainAgreementOption
    {
        public TopLevelDomainAgreementOption() { }
        public bool? ForTransfer { get { throw null; } set { } }
        public bool? IncludePrivacy { get { throw null; } set { } }
    }
    public partial class TriggeredJobRun
    {
        public TriggeredJobRun() { }
        public System.TimeSpan? Duration { get { throw null; } set { } }
        public System.DateTimeOffset? EndTime { get { throw null; } set { } }
        public string ErrorUrl { get { throw null; } set { } }
        public string JobName { get { throw null; } set { } }
        public string OutputUrl { get { throw null; } set { } }
        public System.DateTimeOffset? StartTime { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.TriggeredWebJobStatus? Status { get { throw null; } set { } }
        public string Trigger { get { throw null; } set { } }
        public string Url { get { throw null; } set { } }
        public string WebJobId { get { throw null; } set { } }
        public string WebJobName { get { throw null; } set { } }
    }
    public enum TriggeredWebJobStatus
    {
        Success = 0,
        Failed = 1,
        Error = 2,
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct TriggerTypes : System.IEquatable<Azure.ResourceManager.AppService.Models.TriggerTypes>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public TriggerTypes(string value) { throw null; }
        public static Azure.ResourceManager.AppService.Models.TriggerTypes HttpTrigger { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.TriggerTypes Unknown { get { throw null; } }
        public bool Equals(Azure.ResourceManager.AppService.Models.TriggerTypes other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.AppService.Models.TriggerTypes left, Azure.ResourceManager.AppService.Models.TriggerTypes right) { throw null; }
        public static implicit operator Azure.ResourceManager.AppService.Models.TriggerTypes (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.AppService.Models.TriggerTypes left, Azure.ResourceManager.AppService.Models.TriggerTypes right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class Twitter
    {
        public Twitter() { }
        public bool? Enabled { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.TwitterRegistration Registration { get { throw null; } set { } }
    }
    public partial class TwitterRegistration
    {
        public TwitterRegistration() { }
        public string ConsumerKey { get { throw null; } set { } }
        public string ConsumerSecretSettingName { get { throw null; } set { } }
    }
    public enum UnauthenticatedClientAction
    {
        RedirectToLoginPage = 0,
        AllowAnonymous = 1,
    }
    public enum UnauthenticatedClientActionV2
    {
        RedirectToLoginPage = 0,
        AllowAnonymous = 1,
        Return401 = 2,
        Return403 = 3,
    }
    public enum UsageState
    {
        Normal = 0,
        Exceeded = 1,
    }
    public partial class ValidateRequest
    {
        public ValidateRequest(string name, Azure.ResourceManager.AppService.Models.ValidateResourceTypes validateResourceType, string location) { }
        public Azure.ResourceManager.AppService.Models.AppServiceEnvironmentAutoGenerated AppServiceEnvironment { get { throw null; } set { } }
        public int? Capacity { get { throw null; } set { } }
        public string ContainerImagePlatform { get { throw null; } set { } }
        public string ContainerImageRepository { get { throw null; } set { } }
        public string ContainerImageTag { get { throw null; } set { } }
        public string ContainerRegistryBaseUrl { get { throw null; } set { } }
        public string ContainerRegistryPassword { get { throw null; } set { } }
        public string ContainerRegistryUsername { get { throw null; } set { } }
        public string HostingEnvironment { get { throw null; } set { } }
        public bool? IsSpot { get { throw null; } set { } }
        public bool? IsXenon { get { throw null; } set { } }
        public string Location { get { throw null; } }
        public string Name { get { throw null; } }
        public bool? NeedLinuxWorkers { get { throw null; } set { } }
        public string ServerFarmId { get { throw null; } set { } }
        public string SkuName { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.ValidateResourceTypes ValidateResourceType { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ValidateResourceTypes : System.IEquatable<Azure.ResourceManager.AppService.Models.ValidateResourceTypes>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ValidateResourceTypes(string value) { throw null; }
        public static Azure.ResourceManager.AppService.Models.ValidateResourceTypes MicrosoftWebHostingEnvironments { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.ValidateResourceTypes ServerFarm { get { throw null; } }
        public static Azure.ResourceManager.AppService.Models.ValidateResourceTypes WebSite { get { throw null; } }
        public bool Equals(Azure.ResourceManager.AppService.Models.ValidateResourceTypes other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.AppService.Models.ValidateResourceTypes left, Azure.ResourceManager.AppService.Models.ValidateResourceTypes right) { throw null; }
        public static implicit operator Azure.ResourceManager.AppService.Models.ValidateResourceTypes (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.AppService.Models.ValidateResourceTypes left, Azure.ResourceManager.AppService.Models.ValidateResourceTypes right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ValidateResponse
    {
        internal ValidateResponse() { }
        public Azure.ResourceManager.AppService.Models.ValidateResponseError Error { get { throw null; } }
        public string Status { get { throw null; } }
    }
    public partial class ValidateResponseError
    {
        internal ValidateResponseError() { }
        public string Code { get { throw null; } }
        public string Message { get { throw null; } }
    }
    public partial class VirtualApplication
    {
        public VirtualApplication() { }
        public string PhysicalPath { get { throw null; } set { } }
        public bool? PreloadEnabled { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.VirtualDirectory> VirtualDirectories { get { throw null; } }
        public string VirtualPath { get { throw null; } set { } }
    }
    public partial class VirtualDirectory
    {
        public VirtualDirectory() { }
        public string PhysicalPath { get { throw null; } set { } }
        public string VirtualPath { get { throw null; } set { } }
    }
    public partial class VirtualIPMapping
    {
        public VirtualIPMapping() { }
        public int? InternalHttpPort { get { throw null; } set { } }
        public int? InternalHttpsPort { get { throw null; } set { } }
        public bool? InUse { get { throw null; } set { } }
        public string ServiceName { get { throw null; } set { } }
        public string VirtualIP { get { throw null; } set { } }
    }
    public partial class VirtualNetworkProfile
    {
        public VirtualNetworkProfile(string id) { }
        public string Id { get { throw null; } set { } }
        public string Name { get { throw null; } }
        public string ResourceType { get { throw null; } }
        public string Subnet { get { throw null; } set { } }
    }
    public partial class VnetInfo
    {
        internal VnetInfo() { }
        public string CertBlob { get { throw null; } }
        public string CertThumbprint { get { throw null; } }
        public string DnsServers { get { throw null; } }
        public bool? IsSwift { get { throw null; } }
        public bool? ResyncRequired { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppService.Models.VnetRoute> Routes { get { throw null; } }
        public string VnetResourceId { get { throw null; } }
    }
    public partial class VnetParameters : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public VnetParameters() { }
        public string SubnetResourceId { get { throw null; } set { } }
        public string VnetName { get { throw null; } set { } }
        public string VnetResourceGroup { get { throw null; } set { } }
        public string VnetSubnetName { get { throw null; } set { } }
    }
    public partial class VnetRoute : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public VnetRoute() { }
        public string EndAddress { get { throw null; } set { } }
        public Azure.ResourceManager.AppService.Models.RouteType? RouteType { get { throw null; } set { } }
        public string StartAddress { get { throw null; } set { } }
    }
    public partial class VnetValidationFailureDetails : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public VnetValidationFailureDetails() { }
        public bool? Failed { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.VnetValidationTestFailure> FailedTests { get { throw null; } }
        public string Message { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppService.Models.VnetValidationTestFailure> Warnings { get { throw null; } }
    }
    public partial class VnetValidationTestFailure : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public VnetValidationTestFailure() { }
        public string Details { get { throw null; } set { } }
        public string TestName { get { throw null; } set { } }
    }
    public partial class WebAppMajorVersion
    {
        internal WebAppMajorVersion() { }
        public string DisplayText { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppService.Models.WebAppMinorVersion> MinorVersions { get { throw null; } }
        public string Value { get { throw null; } }
    }
    public partial class WebAppMinorVersion
    {
        internal WebAppMinorVersion() { }
        public string DisplayText { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.WebAppRuntimes StackSettings { get { throw null; } }
        public string Value { get { throw null; } }
    }
    public partial class WebAppRuntimes
    {
        internal WebAppRuntimes() { }
        public Azure.ResourceManager.AppService.Models.LinuxJavaContainerSettings LinuxContainerSettings { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.WebAppRuntimeSettings LinuxRuntimeSettings { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.WindowsJavaContainerSettings WindowsContainerSettings { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.WebAppRuntimeSettings WindowsRuntimeSettings { get { throw null; } }
    }
    public partial class WebAppRuntimeSettings
    {
        internal WebAppRuntimeSettings() { }
        public Azure.ResourceManager.AppService.Models.AppInsightsWebAppStackSettings AppInsightsSettings { get { throw null; } }
        public System.DateTimeOffset? EndOfLifeDate { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.GitHubActionWebAppStackSettings GitHubActionSettings { get { throw null; } }
        public bool? IsAutoUpdate { get { throw null; } }
        public bool? IsDeprecated { get { throw null; } }
        public bool? IsEarlyAccess { get { throw null; } }
        public bool? IsHidden { get { throw null; } }
        public bool? IsPreview { get { throw null; } }
        public bool? RemoteDebuggingSupported { get { throw null; } }
        public string RuntimeVersion { get { throw null; } }
    }
    public partial class WebAppStack : Azure.ResourceManager.AppService.Models.ProxyOnlyResource
    {
        public WebAppStack() { }
        public string DisplayText { get { throw null; } }
        public string Location { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppService.Models.WebAppMajorVersion> MajorVersions { get { throw null; } }
        public Azure.ResourceManager.AppService.Models.StackPreferredOs? PreferredOs { get { throw null; } }
        public string Value { get { throw null; } }
    }
    public enum WebJobType
    {
        Continuous = 0,
        Triggered = 1,
    }
    public partial class WindowsJavaContainerSettings
    {
        internal WindowsJavaContainerSettings() { }
        public System.DateTimeOffset? EndOfLifeDate { get { throw null; } }
        public bool? IsAutoUpdate { get { throw null; } }
        public bool? IsDeprecated { get { throw null; } }
        public bool? IsEarlyAccess { get { throw null; } }
        public bool? IsHidden { get { throw null; } }
        public bool? IsPreview { get { throw null; } }
        public string JavaContainer { get { throw null; } }
        public string JavaContainerVersion { get { throw null; } }
    }
    public enum WorkerSizeOptions
    {
        Small = 0,
        Medium = 1,
        Large = 2,
        D1 = 3,
        D2 = 4,
        D3 = 5,
        SmallV3 = 6,
        MediumV3 = 7,
        LargeV3 = 8,
        NestedSmall = 9,
        NestedSmallLinux = 10,
        Default = 11,
    }
}
