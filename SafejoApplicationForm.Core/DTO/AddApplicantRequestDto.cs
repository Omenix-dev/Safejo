namespace SafejoApplicationForm.Core.DTO
{
    public class AddApplicantRequestDto
    {
        public int Department { get; set; }
        public string JobRole { get; set; }
        public ApplicantBioDataDto ApplicationBioDataDto { get; set; }
        public ApplicantEducationDto ApplicantEdacationDto { get; set; }
        public IEnumerable<ApplicantProfessionsDto> ApplicantProfessionsDto { get; set; }
        public IEnumerable<JobExperienceDto> JobExperienceDto { get; set; }
    }
}
