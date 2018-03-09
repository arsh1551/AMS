using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAcessLayer.Models;
using DataAcessLayer.ViewModels;


namespace RepositoryLayer.Interfaces
{
    public interface IAssociateRepo
    {
        Associate GetAssociateById(int associateId);
        List<Associate> GetAssociates();
        void SaveAssociate(Associate associate);
        void DeleteAssociate(int associateId);
        List<Specialization> GetSpecializaions(AssociateViewModel associateViewModel);
        List<Specialization> GetSpecializaionsAll();

    }
}