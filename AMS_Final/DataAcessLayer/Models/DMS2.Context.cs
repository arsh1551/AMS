﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAcessLayer.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DMS2DataContext : DbContext
    {
        public DMS2DataContext()
            : base("name=DMS2DataContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ClientAssociate> ClientAssociates { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<Firm> Firms { get; set; }
        public virtual DbSet<FolderPermission> FolderPermissions { get; set; }
        public virtual DbSet<Folder> Folders { get; set; }
        public virtual DbSet<IndividualRole> IndividualRoles { get; set; }
        public virtual DbSet<Individual> Individuals { get; set; }
        public virtual DbSet<LogInfo> LogInfoes { get; set; }
        public virtual DbSet<LogProperty> LogProperties { get; set; }
        public virtual DbSet<LogPropertyChanx> LogPropertyChanges { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<LogType> LogTypes { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User_Test> User_Test { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
    
        public virtual ObjectResult<GetAssociatesFirmsClients_Result> GetAssociatesFirmsClients(Nullable<long> individualId)
        {
            var individualIdParameter = individualId.HasValue ?
                new ObjectParameter("individualId", individualId) :
                new ObjectParameter("individualId", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAssociatesFirmsClients_Result>("GetAssociatesFirmsClients", individualIdParameter);
        }
    
        public virtual ObjectResult<Nullable<long>> sp_CreateFolder(Nullable<int> roleId, Nullable<long> createdBy, Nullable<long> ownerId, Nullable<long> parentFolderId, Nullable<long> individualId, string folderPath, string folderName, Nullable<bool> canCreate, Nullable<bool> canDownload, Nullable<bool> canDelete, Nullable<bool> canUpload)
        {
            var roleIdParameter = roleId.HasValue ?
                new ObjectParameter("RoleId", roleId) :
                new ObjectParameter("RoleId", typeof(int));
    
            var createdByParameter = createdBy.HasValue ?
                new ObjectParameter("CreatedBy", createdBy) :
                new ObjectParameter("CreatedBy", typeof(long));
    
            var ownerIdParameter = ownerId.HasValue ?
                new ObjectParameter("OwnerId", ownerId) :
                new ObjectParameter("OwnerId", typeof(long));
    
            var parentFolderIdParameter = parentFolderId.HasValue ?
                new ObjectParameter("ParentFolderId", parentFolderId) :
                new ObjectParameter("ParentFolderId", typeof(long));
    
            var individualIdParameter = individualId.HasValue ?
                new ObjectParameter("IndividualId", individualId) :
                new ObjectParameter("IndividualId", typeof(long));
    
            var folderPathParameter = folderPath != null ?
                new ObjectParameter("FolderPath", folderPath) :
                new ObjectParameter("FolderPath", typeof(string));
    
            var folderNameParameter = folderName != null ?
                new ObjectParameter("FolderName", folderName) :
                new ObjectParameter("FolderName", typeof(string));
    
            var canCreateParameter = canCreate.HasValue ?
                new ObjectParameter("CanCreate", canCreate) :
                new ObjectParameter("CanCreate", typeof(bool));
    
            var canDownloadParameter = canDownload.HasValue ?
                new ObjectParameter("CanDownload", canDownload) :
                new ObjectParameter("CanDownload", typeof(bool));
    
            var canDeleteParameter = canDelete.HasValue ?
                new ObjectParameter("CanDelete", canDelete) :
                new ObjectParameter("CanDelete", typeof(bool));
    
            var canUploadParameter = canUpload.HasValue ?
                new ObjectParameter("CanUpload", canUpload) :
                new ObjectParameter("CanUpload", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<long>>("sp_CreateFolder", roleIdParameter, createdByParameter, ownerIdParameter, parentFolderIdParameter, individualIdParameter, folderPathParameter, folderNameParameter, canCreateParameter, canDownloadParameter, canDeleteParameter, canUploadParameter);
        }
    
        public virtual int sp_deleteFirm(Nullable<int> firmId)
        {
            var firmIdParameter = firmId.HasValue ?
                new ObjectParameter("firmId", firmId) :
                new ObjectParameter("firmId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_deleteFirm", firmIdParameter);
        }
    
        public virtual int sp_deleteFirms(Nullable<int> firmId)
        {
            var firmIdParameter = firmId.HasValue ?
                new ObjectParameter("firmId", firmId) :
                new ObjectParameter("firmId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_deleteFirms", firmIdParameter);
        }
    
        public virtual ObjectResult<sp_getAssociatedIndividuals_Result> sp_getAssociatedIndividuals(Nullable<long> clientId)
        {
            var clientIdParameter = clientId.HasValue ?
                new ObjectParameter("ClientId", clientId) :
                new ObjectParameter("ClientId", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_getAssociatedIndividuals_Result>("sp_getAssociatedIndividuals", clientIdParameter);
        }
    
        public virtual int sp_GetClients_Search(Nullable<long> firmId, string searchItem, string isIndividual)
        {
            var firmIdParameter = firmId.HasValue ?
                new ObjectParameter("FirmId", firmId) :
                new ObjectParameter("FirmId", typeof(long));
    
            var searchItemParameter = searchItem != null ?
                new ObjectParameter("searchItem", searchItem) :
                new ObjectParameter("searchItem", typeof(string));
    
            var isIndividualParameter = isIndividual != null ?
                new ObjectParameter("isIndividual", isIndividual) :
                new ObjectParameter("isIndividual", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_GetClients_Search", firmIdParameter, searchItemParameter, isIndividualParameter);
        }
    
        public virtual int sp_GetClients_Search_Test(Nullable<long> firmId, string searchItem, string isIndividual)
        {
            var firmIdParameter = firmId.HasValue ?
                new ObjectParameter("FirmId", firmId) :
                new ObjectParameter("FirmId", typeof(long));
    
            var searchItemParameter = searchItem != null ?
                new ObjectParameter("searchItem", searchItem) :
                new ObjectParameter("searchItem", typeof(string));
    
            var isIndividualParameter = isIndividual != null ?
                new ObjectParameter("isIndividual", isIndividual) :
                new ObjectParameter("isIndividual", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_GetClients_Search_Test", firmIdParameter, searchItemParameter, isIndividualParameter);
        }
    
        public virtual int sp_GetClients_Search_TestNew(Nullable<long> firmId, string searchItem, string isIndividual, Nullable<long> loginUserId)
        {
            var firmIdParameter = firmId.HasValue ?
                new ObjectParameter("FirmId", firmId) :
                new ObjectParameter("FirmId", typeof(long));
    
            var searchItemParameter = searchItem != null ?
                new ObjectParameter("searchItem", searchItem) :
                new ObjectParameter("searchItem", typeof(string));
    
            var isIndividualParameter = isIndividual != null ?
                new ObjectParameter("isIndividual", isIndividual) :
                new ObjectParameter("isIndividual", typeof(string));
    
            var loginUserIdParameter = loginUserId.HasValue ?
                new ObjectParameter("LoginUserId", loginUserId) :
                new ObjectParameter("LoginUserId", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_GetClients_Search_TestNew", firmIdParameter, searchItemParameter, isIndividualParameter, loginUserIdParameter);
        }
    
        public virtual ObjectResult<sp_getclientsbyIndividualId_Result> sp_getclientsbyIndividualId(Nullable<long> individualid)
        {
            var individualidParameter = individualid.HasValue ?
                new ObjectParameter("individualid", individualid) :
                new ObjectParameter("individualid", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_getclientsbyIndividualId_Result>("sp_getclientsbyIndividualId", individualidParameter);
        }
    
        public virtual ObjectResult<SP_GetDataByFolderId_Result> SP_GetDataByFolderId(Nullable<long> folderId)
        {
            var folderIdParameter = folderId.HasValue ?
                new ObjectParameter("FolderId", folderId) :
                new ObjectParameter("FolderId", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GetDataByFolderId_Result>("SP_GetDataByFolderId", folderIdParameter);
        }
    
        public virtual ObjectResult<sp_GetFoldersByParentFolderId_Result> sp_GetFoldersByParentFolderId(Nullable<long> folderId, Nullable<long> individualId)
        {
            var folderIdParameter = folderId.HasValue ?
                new ObjectParameter("FolderId", folderId) :
                new ObjectParameter("FolderId", typeof(long));
    
            var individualIdParameter = individualId.HasValue ?
                new ObjectParameter("IndividualId", individualId) :
                new ObjectParameter("IndividualId", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetFoldersByParentFolderId_Result>("sp_GetFoldersByParentFolderId", folderIdParameter, individualIdParameter);
        }
    
        public virtual ObjectResult<sp_GetFoldersWithPermissions_Result> sp_GetFoldersWithPermissions(Nullable<long> roleId, Nullable<long> ownerId, Nullable<long> firmid, Nullable<long> clientId)
        {
            var roleIdParameter = roleId.HasValue ?
                new ObjectParameter("RoleId", roleId) :
                new ObjectParameter("RoleId", typeof(long));
    
            var ownerIdParameter = ownerId.HasValue ?
                new ObjectParameter("OwnerId", ownerId) :
                new ObjectParameter("OwnerId", typeof(long));
    
            var firmidParameter = firmid.HasValue ?
                new ObjectParameter("firmid", firmid) :
                new ObjectParameter("firmid", typeof(long));
    
            var clientIdParameter = clientId.HasValue ?
                new ObjectParameter("clientId", clientId) :
                new ObjectParameter("clientId", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetFoldersWithPermissions_Result>("sp_GetFoldersWithPermissions", roleIdParameter, ownerIdParameter, firmidParameter, clientIdParameter);
        }
    
        public virtual ObjectResult<SP_GetIndividualByclientId_Result> SP_GetIndividualByclientId(Nullable<long> clientId)
        {
            var clientIdParameter = clientId.HasValue ?
                new ObjectParameter("ClientId", clientId) :
                new ObjectParameter("ClientId", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GetIndividualByclientId_Result>("SP_GetIndividualByclientId", clientIdParameter);
        }
    
        public virtual int SP_GetIndividualEmailDetails(string individualIds)
        {
            var individualIdsParameter = individualIds != null ?
                new ObjectParameter("individualIds", individualIds) :
                new ObjectParameter("individualIds", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_GetIndividualEmailDetails", individualIdsParameter);
        }
    
        public virtual ObjectResult<SP_GetIndividualForInvitations_Result> SP_GetIndividualForInvitations(Nullable<long> clientId)
        {
            var clientIdParameter = clientId.HasValue ?
                new ObjectParameter("ClientId", clientId) :
                new ObjectParameter("ClientId", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GetIndividualForInvitations_Result>("SP_GetIndividualForInvitations", clientIdParameter);
        }
    
        public virtual ObjectResult<sp_GetInviteList_Result> sp_GetInviteList(Nullable<long> firmId, Nullable<long> roleID, Nullable<long> createdBy)
        {
            var firmIdParameter = firmId.HasValue ?
                new ObjectParameter("FirmId", firmId) :
                new ObjectParameter("FirmId", typeof(long));
    
            var roleIDParameter = roleID.HasValue ?
                new ObjectParameter("RoleID", roleID) :
                new ObjectParameter("RoleID", typeof(long));
    
            var createdByParameter = createdBy.HasValue ?
                new ObjectParameter("createdBy", createdBy) :
                new ObjectParameter("createdBy", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetInviteList_Result>("sp_GetInviteList", firmIdParameter, roleIDParameter, createdByParameter);
        }
    
        public virtual ObjectResult<sp_GetInviteList_test_Result> sp_GetInviteList_test(Nullable<long> firmId, Nullable<long> roleID, Nullable<long> createdBy)
        {
            var firmIdParameter = firmId.HasValue ?
                new ObjectParameter("FirmId", firmId) :
                new ObjectParameter("FirmId", typeof(long));
    
            var roleIDParameter = roleID.HasValue ?
                new ObjectParameter("RoleID", roleID) :
                new ObjectParameter("RoleID", typeof(long));
    
            var createdByParameter = createdBy.HasValue ?
                new ObjectParameter("createdBy", createdBy) :
                new ObjectParameter("createdBy", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetInviteList_test_Result>("sp_GetInviteList_test", firmIdParameter, roleIDParameter, createdByParameter);
        }
    
        public virtual ObjectResult<sp_getUserByEmail_Result> sp_getUserByEmail(string email)
        {
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_getUserByEmail_Result>("sp_getUserByEmail", emailParameter);
        }
    
        public virtual ObjectResult<sp_getUsersInRoleByFirmOrClient_Result> sp_getUsersInRoleByFirmOrClient(Nullable<long> firmId, Nullable<long> clientId)
        {
            var firmIdParameter = firmId.HasValue ?
                new ObjectParameter("FirmId", firmId) :
                new ObjectParameter("FirmId", typeof(long));
    
            var clientIdParameter = clientId.HasValue ?
                new ObjectParameter("ClientId", clientId) :
                new ObjectParameter("ClientId", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_getUsersInRoleByFirmOrClient_Result>("sp_getUsersInRoleByFirmOrClient", firmIdParameter, clientIdParameter);
        }
    
        public virtual ObjectResult<sp_userlogin_Result> sp_userlogin(string email, string password)
        {
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_userlogin_Result>("sp_userlogin", emailParameter, passwordParameter);
        }
    
        public virtual ObjectResult<ssp_getassociatedfirmsorclients_Result> ssp_getassociatedfirmsorclients(Nullable<long> individualid)
        {
            var individualidParameter = individualid.HasValue ?
                new ObjectParameter("individualid", individualid) :
                new ObjectParameter("individualid", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ssp_getassociatedfirmsorclients_Result>("ssp_getassociatedfirmsorclients", individualidParameter);
        }

        public System.Data.Entity.DbSet<DataAcessLayer.ViewModels.UserViewModel> UserViewModels { get; set; }
    }
}
