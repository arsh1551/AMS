using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcessLayer.Models;
using ServiceLayer.Interfaces;
using RepositoryLayer.Interfaces;
using System.Data.Entity;
using DataAcessLayer.ViewModels;

namespace RepositoryLayer.Repositories
{
    public class AssociateService : IAssociateService
    {
        public IAssociateRepo _associateRepo = null;
        public AssociateService(IAssociateRepo objAssociateRepo)
        {
            _associateRepo = objAssociateRepo;

        }

        public List<AssociateViewModel> GetAssociates()
        {

            try
            {
                List<AssociateViewModel> listAssociateViewModel = _associateRepo.GetAssociates().Select(a => new AssociateViewModel
                {
                    AssociateId = a.AssociateId,
                    AssociateName = a.AssociateName,
                    AssociateAddress = a.AssociateAddress,
                    AssociatePhone = a.AssociatePhone,
                    Specializations = a.Specializations
                  .Select(sp => new SpecializationViewModel { SpecializationId = sp.SpecializationId, SpecializationName = sp.SpecializationName }).ToList()
                })
                .ToList();                
                return listAssociateViewModel;
            }
            catch
            {
                throw;

            }

        }
      
        public void SaveAssociate(AssociateViewModel associateViewModel)
        {
            try
            {
                Associate objAssociate = new Associate()
                {

                    AssociateId = associateViewModel.AssociateId,
                    AssociateName = associateViewModel.AssociateName,
                    AssociateAddress = associateViewModel.AssociateAddress,
                    AssociatePhone = associateViewModel.AssociatePhone,
                    Specializations = _associateRepo.GetSpecializaions(associateViewModel)
                };
                _associateRepo.SaveAssociate(objAssociate);
            }
            catch (Exception e)
            {
               
            }

        }

        public AssociateViewModel GetAssociateById(int associateId)
        {

            Associate associate = _associateRepo.GetAssociateById(associateId);
            if (associate != null)
            {
                AssociateViewModel associateViewModel = new AssociateViewModel
                {
                    AssociateId = associate.AssociateId,
                    AssociateName = associate.AssociateName,
                    AssociateAddress = associate.AssociateAddress,
                    AssociatePhone = associate.AssociatePhone,
                    specializationIds = associate.Specializations.Select(x => x.SpecializationId).ToList(),
                    Specializations = _associateRepo.GetSpecializaionsAll().Select(s => new SpecializationViewModel { SpecializationId = s.SpecializationId, SpecializationName = s.SpecializationName }).ToList()

                };
                return associateViewModel;
            }
            //else part later
            else
            {
                return null;
            }
        }

        public void DeleteAssociate(int associateId)
        {

            try
            {
                _associateRepo.DeleteAssociate(associateId);
            }
            catch (Exception e)
            {
                throw;
            }

        }

        public List<SpecializationViewModel> GetSpecializationsAll()
        {
            List<SpecializationViewModel> listSpecializations= _associateRepo.GetSpecializaionsAll().Select(s => new SpecializationViewModel { SpecializationId = s.SpecializationId, SpecializationName = s.SpecializationName }).ToList();
            return listSpecializations;
        }
    }
}
