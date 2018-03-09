using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAcessLayer.Models;
using DataAcessLayer.ViewModels;


namespace ServiceLayer.Interfaces
{
    public interface IAssociateService
    {
        AssociateViewModel GetAssociateById(int associateId);
        List<AssociateViewModel> GetAssociates();
        void SaveAssociate(AssociateViewModel associateViewModel);
        void DeleteAssociate(int associateId);
        List<SpecializationViewModel> GetSpecializationsAll();

    }
}