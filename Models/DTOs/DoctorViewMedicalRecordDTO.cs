namespace AmazeCare.Models.DTOs
{
    public class DoctorViewMedicalRecordDTO
    {
        public string PatientName { get; set; } = string.Empty;

        public string DoctorName { get; set; } = string.Empty;
        public int RecordId { get; set; }

        public string CurrentSymptoms { get; set; } = string.Empty;

        public string PhysicalExamination { get; set; } = string.Empty;

        public string TreatmentPlan { get; set; } = string.Empty;

        public string RecommendedTests { get; set; } = string.Empty;

        public int AppointmentId { get; set; }
    }
}