using Doctor.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Doctor.Services
{
    public interface IAppointmentService
    {
        public List<DoctorVM> GetDoctorList();
        public List<PatientVM> GetPatientList();
        public Task<int> AddUpdate(AppointmentVM model);

        public List<AppointmentVM> DoctorEventsById(string doctorId);

        public List<AppointmentVM> PatientEventsById(string patientId);

        public AppointmentVM GetById(int id);

        public Task<int> Delete(int id);

        public Task<int> ConfirmEvent(int id);
    }
}
