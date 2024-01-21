namespace apbd_8_s22085.Dtos;

public record PrescriptionInfoDto(
    int IdPrescription,
    DateOnly Date,
    DateOnly DueDate,
    DoctorInfoDto Doctor,
    PatientInfoDto Patient,
    IEnumerable<MedicamentInfoDto> Medicaments);
    
public record PatientInfoDto(
    int IdPatient,
    string FirstName,
    string LastName,
    DateOnly Birthdate);
    
public record MedicamentInfoDto(
    string Name,
    string Description,
    string Type,
    int Dose,
    string Details);