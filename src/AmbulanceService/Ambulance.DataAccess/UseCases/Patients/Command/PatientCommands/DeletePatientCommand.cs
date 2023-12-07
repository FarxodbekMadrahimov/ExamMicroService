using MediatR;


namespace Ambulance.Application.UseCases.Patients.Command.PatientCommands
{
    public class DeletePatientCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
