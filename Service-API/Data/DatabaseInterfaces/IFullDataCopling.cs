using Service_API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_API.Data.Interface
{
    interface IFullDataCopling : ICompany, IEducationAgreementSubType, ILog, ISpecialAgreement, ICreateUser, IEducationAgreementType, ILogDatabaseUpdate,  ISpecialAgreementList, IEducationAgreement, IEducationalConnection, ISchool, ISpecialization, IEducationAgreementCategory, ISchoolAgreement, IUserInformation, IEducationAgreementOrigin, ILearingnActivity, ISchoolCouse
    {

    }
}
