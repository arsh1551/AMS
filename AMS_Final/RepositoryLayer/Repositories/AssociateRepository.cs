using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcessLayer.Models;
using DataAcessLayer.ViewModels;
using RepositoryLayer.Interfaces;
using System.Data.Entity;

namespace RepositoryLayer.Repositories
{
    public class AssociateRepository : IAssociateRepo
    {
        #region Initialize
        UnityOfWork uow = null;
        ContextAMS amsContext;
        public AssociateRepository()
        {
            if (uow == null)
            {
                amsContext = new ContextAMS();
                uow = new UnityOfWork(amsContext);
            }
        }
        #endregion

        #region Dispose
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose managed resources
                this.uow.Dispose();
                this.amsContext.Database.Connection.Close();
                this.amsContext.Dispose();
            }
            // free native resources
        }
        #endregion


        public List<Associate> GetAssociates()
        {

            try
            {
                // List<Associate> userList = uow.Repository<Associate>().GetAll().ToList();
                List<Associate> listAssociate = amsContext.Associates.Include(a => a.Specializations).ToList();
                return listAssociate;
            }
            catch
            {
                throw;

            }

        }


        public void SaveAssociate(Associate associate)
        {
            try
            {
                if (associate.AssociateId == 0)
                {

                    uow.Repository<Associate>().Add(associate);
                    uow.SaveChanges();
                }

                else
                {
                    Associate objassociate = GetAssociateById(associate.AssociateId);


                   // objassociate.AssociateId = associate.AssociateId;
                    objassociate.AssociateName = associate.AssociateName;
                    objassociate.AssociateAddress = associate.AssociateAddress;
                    objassociate.AssociatePhone = associate.AssociatePhone;
                    objassociate.Specializations = associate.Specializations;
                    uow.SaveChanges();

                }
            }
            catch (Exception e)
            {

            }

        }

        public Associate GetAssociateById(int associateId)
        {
            try
            {
                Associate associate = amsContext.Associates.Where(a => a.AssociateId == associateId).Include(x => x.Specializations).FirstOrDefault();
                return associate;
            }
            catch
            {
                throw;

            }
           
        }


        public void DeleteAssociate(int associateId)
        {
            try
            {
                Associate associate=GetAssociateById(associateId);
                amsContext.Associates.Remove(associate);
                amsContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw;
            }

        }

        public List<Specialization> GetSpecializaions(AssociateViewModel associateViewModel)
        {
            List<Specialization> listSpecialization = amsContext.Specializations.Where(speclztn => associateViewModel.specializationIds.Contains(speclztn.SpecializationId)).ToList();
            return listSpecialization;
        }

        public List<Specialization> GetSpecializaionsAll()
        {
            return amsContext.Specializations.ToList();
        }

    }
}
