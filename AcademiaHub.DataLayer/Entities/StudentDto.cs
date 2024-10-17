﻿
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace AcademiaHub.DataLayer.Entities
{
    public class StudentDto
    {
        public int EnrollmentNo { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MotherTongue { get; set; }
        public string? Religion { get; set; }
        public string? Gender { get; set; }
        public string? Village { get; set; }
        public string? Town { get; set; }
        public string? State { get; set; }
        public string? Email { get; set; }
        public string? PlaceOfBirth { get; set; }
        public string? Mobile { get; set; }
        public string? AadharNumber { get; set; }
        public int ClassId { get; set; }
        public int SectionId { get; set; }
        public int ParentId { get; set; }
        public int GuardianId { get; set; } 
        public int HostelerId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime AdmissionDate { get; set; }
        public IFormFile? ImageFile { get; set; }
        public bool IsActive { get; set; }
    }
}
