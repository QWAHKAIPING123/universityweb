using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using UniversityWebApplication.Models;

namespace UniversityWebApplication.Controllers
{
    public class UniversityInfoesController : Controller
    {
        private UniversityEntities db = new UniversityEntities();
        
        public ActionResult Demo(String TuitionDomUnderRange, String TuitionIntUnderRange, String TuitionDomPostRange, String TuitionIntPostRange, String CostOfLivingRange, string Country,string Type,string Campus_Setting,string Qualification_Type, Nullable<bool> Accounting, Nullable<bool> Accounting_Technician, Nullable<bool> Actuarial_Science, Nullable<bool> Adult_Development_Aging_Gerontology, Nullable<bool> Advertising, Nullable<bool> Aeronautical_Astronautical_Engineering_Technologies, Nullable<bool> Aeronautical_Astronautical_Engineering, Nullable<bool> African_American_Studies, Nullable<bool> Agribusiness_Operations, Nullable<bool> Agricultural_Business_Management, Nullable<bool> Agricultural_Economics, Nullable<bool> Agricultural_Education, Nullable<bool> Agricultural_Mechanization, Nullable<bool> Agricultural_Production, Nullable<bool> Agricultural_Bioengineering, Nullable<bool> Agriculture_General, Nullable<bool> Agronomy_Crop_Science, Nullable<bool> Aircraft_Mechanics_Technology, Nullable<bool> Aircraft_Piloting_Navigation, Nullable<bool> Alcohol_Drug_Abuse_Counseling, Nullable<bool> American_Indian_Native_American_Studies, Nullable<bool> American_English_Literature, Nullable<bool> Animal_Sciences, Nullable<bool> Anthropology, Nullable<bool> Applied_Mathematics, Nullable<bool> Architectural_Drafting_CAD_Technology, Nullable<bool> Architectural_Engineering, Nullable<bool> Architectural_Engineering_Technology, Nullable<bool> Architectural_Environmental_Design, Nullable<bool> Architecture_General, Nullable<bool> Area_Studies_General_e_g_African_Middle_Eastern, Nullable<bool> Art_Education, Nullable<bool> Art_History_Criticism_Conservation, Nullable<bool> Art_General, Nullable<bool> Asian_Area_Studies, Nullable<bool> Asian_Languages_Literatures, Nullable<bool> Astronomy, Nullable<bool> Athletic_Training, Nullable<bool> Atmospheric_Sciences_Meteorology, Nullable<bool> Autobody_Repair_Technology, Nullable<bool> Automotive_Engineering_Technology, Nullable<bool> Automotive_Mechanics_Technology, Nullable<bool> Aviation_Airway_Science_General, Nullable<bool> Aviation_Management_Operations, Nullable<bool> Avionics_Technology, Nullable<bool> Banking_Financial_Support_Services, Nullable<bool> Bible_Biblical_Studies, Nullable<bool> Biochemistry_Biophysics, Nullable<bool> Biology_General, Nullable<bool> Biomedical_Engineering, Nullable<bool> Business_Administration_Management_General, Nullable<bool> Business_Education, Nullable<bool> Business_Management_Quantitative_Methods_General, Nullable<bool> Business_Managerial_Economics, Nullable<bool> Career_Technical_Education, Nullable<bool> Cell_Cellular_Biology, Nullable<bool> Chemical_Engineering, Nullable<bool> Chemistry, Nullable<bool> Child_Care_Services_Management, Nullable<bool> Child_Development, Nullable<bool> Chiropractic_Pre_Chiropractic, Nullable<bool> Cinema_Film, Nullable<bool> Cinematography_Film_Video_Production, Nullable<bool> City_Urban_Regional_Planning, Nullable<bool> Civil_Engineering, Nullable<bool> Civil_Engineering_Technology, Nullable<bool> Classical_Ancient_Languages_Literatures, Nullable<bool> Communication_Disorder_Services_e_g_Speech_Pathology, Nullable<bool> Communications_Technology_General, Nullable<bool> Communications_General, Nullable<bool> Community_Organization_Advocacy, Nullable<bool> Comparative_Literature, Nullable<bool> Computer_Information_Sciences_General, Nullable<bool> Computer_Engineering, Nullable<bool> Computer_Engineering_Technology, Nullable<bool> Computer_Networking_Telecommunications, Nullable<bool> Computer_Science_Programming, Nullable<bool> Computer_Software_Media_Applications, Nullable<bool> Computer_System_Administration, Nullable<bool> Construction_Engineering_Management, Nullable<bool> Construction_Trades_e_g_carpentry_plumbing_electrical, Nullable<bool> Construction_Building_Technology, Nullable<bool> Consumer_Family_Economics, Nullable<bool> Corrections, Nullable<bool> Cosmetology_Hairstyling, Nullable<bool> Counseling_Student_Services, Nullable<bool> Court_Reporting, Nullable<bool> Creative_Writing, Nullable<bool> Criminal_Justice, Nullable<bool> Criminology, Nullable<bool> Culinary_Arts_Chef_Training, Nullable<bool> Curriculum_Instruction, Nullable<bool> Dance, Nullable<bool> Data_Management_Technology, Nullable<bool> Dental_Assisting, Nullable<bool> Dental_Hygiene, Nullable<bool> Dentistry_Pre_Dentistry, Nullable<bool> Design_Visual_Communications_General, Nullable<bool> Diesel_Mechanics_Technology, Nullable<bool> Digital_Communications_Media, Nullable<bool> Divinity_Ministry, Nullable<bool> Drafting_CAD_Technology_General, Nullable<bool> Early_Childhood_Education, Nullable<bool> Ecology, Nullable<bool> Economics, Nullable<bool> Educational_Administration, Nullable<bool> Electrical_Electronics_Communications_Engineering, Nullable<bool> Electrical_Electronics_Engineering_Technologies, Nullable<bool> Electrical_Electronics_Equip_Installation_Repair, Nullable<bool> Electromechanical_Biomedical_Engineering_Technologies, Nullable<bool> Elementary_Education, Nullable<bool> Emergency_Medical_Technology, Nullable<bool> Engineering_Pre_Engineering_General, Nullable<bool> Engineering_Technology_General, Nullable<bool> English_Language_Literature_General, Nullable<bool> English_Language_Arts_Education, Nullable<bool> English_as_a_Second_Language_Education, Nullable<bool> Environmental_Control_Technologies, Nullable<bool> Environmental_Health_Engineering, Nullable<bool> Environmental_Science, Nullable<bool> Ethnic_Minority_Studies_General, Nullable<bool> European_Area_Studies, Nullable<bool> Exercise_Science_Physiology_Kinesiology, Nullable<bool> Family_Consumer_Sciences_General, Nullable<bool> Fashion_Merchandising, Nullable<bool> Fashion_Apparel_Design, Nullable<bool> Finance_General, Nullable<bool> Financial_Planning_Services, Nullable<bool> Fine_Studio_Arts, Nullable<bool> Fire_Protection_Safety_Technology, Nullable<bool> Food_Nutrition, Nullable<bool> Food_Sciences_Technology, Nullable<bool> Foreign_Languages_Education, Nullable<bool> Foreign_Languages_Literatures_General, Nullable<bool> Forestry, Nullable<bool> French_Language_Literature, Nullable<bool> Funeral_Services_Mortuary_Science, Nullable<bool> Genetics, Nullable<bool> Geography, Nullable<bool> Geological_Earth_Sciences, Nullable<bool> German_Language_Literature, Nullable<bool> Graphic_Printing_Equipment_Operation, Nullable<bool> Graphic_Design, Nullable<bool> Health_Physical_Education_Fitness, Nullable<bool> Health_Education, Nullable<bool> Health_Services_Administration_General, Nullable<bool> Health_Medical_Technology_General, Nullable<bool> Health_Related_Professions_Services_General, Nullable<bool> Heating_Air_Cond_Refrig_Install_Repair, Nullable<bool> History, Nullable<bool> Horticulture_Operations_Management, Nullable<bool> Horticulture_Science, Nullable<bool> Hospital_Facilities_Administration, Nullable<bool> Hotel_Motel_Management, Nullable<bool> Human_Resources_Development_Training, Nullable<bool> Human_Resources_Management, Nullable<bool> Industrial_Design, Nullable<bool> Industrial_Engineering, Nullable<bool> Industrial_Production_Technologies, Nullable<bool> Information_Science, Nullable<bool> Insurance_Risk_Management, Nullable<bool> Interior_Architecture, Nullable<bool> Interior_Design, Nullable<bool> International_Business_Management, Nullable<bool> International_Relations_Affairs, Nullable<bool> Investments_Securities, Nullable<bool> Journalism_Broadcast, Nullable<bool> Journalism_Print, Nullable<bool> Junior_High_Middle_School_Education, Nullable<bool> Labor_Industrial_Relations, Nullable<bool> Landscape_Architecture, Nullable<bool> Latin_American_Area_Studies, Nullable<bool> Latino_Chicano_Studies, Nullable<bool> Law_Pre_Law, Nullable<bool> Law_Enforcement, Nullable<bool> Legal_Administrative_Assisting_Secretarial, Nullable<bool> Legal_Studies_General, Nullable<bool> Liberal_Arts_General_Studies, Nullable<bool> Library_Science, Nullable<bool> Linguistics, Nullable<bool> Logistics_Materials_Management, Nullable<bool> Machine_Tool_Technology, Nullable<bool> Management_Information_Systems, Nullable<bool> Marine_Aquatic_Biology, Nullable<bool> Marketing_Management_Research, Nullable<bool> Mass_Communications, Nullable<bool> Massage_Therapy, Nullable<bool> Mathematics_Education, Nullable<bool> Mathematics_General, Nullable<bool> Mechanical_Drafting_CAD_Technology, Nullable<bool> Mechanical_Engineering, Nullable<bool> Mechanical_Engineering_Technology, Nullable<bool> Mechanics_Repairers_General, Nullable<bool> Medical_Assisting, Nullable<bool> Medical_Laboratory_Technology, Nullable<bool> Medical_Office_Secretarial, Nullable<bool> Medical_Radiologic_Technology, Nullable<bool> Medical_Records, Nullable<bool> Medical_Clinical_Assisting_General, Nullable<bool> Medicine_Pre_Medicine, Nullable<bool> Mental_Health_Counseling, Nullable<bool> Microbiology_Immunology, Nullable<bool> Middle_Eastern_Languages_Literatures, Nullable<bool> Military_Technologies, Nullable<bool> Multi_Interdisciplinary_Studies, Nullable<bool> Multimedia_Animation_Special_Effects, Nullable<bool> Music_Education, Nullable<bool> Music_General, Nullable<bool> Music_Performance, Nullable<bool> Music_Theory_Composition, Nullable<bool> Natural_Resources_Conservation_General, Nullable<bool> Natural_Resources_Management, Nullable<bool> North_American_Area_Studies, Nullable<bool> Nuclear_Engineering, Nullable<bool> Nuclear_Medicine_Technology, Nullable<bool> Nursing_Practical_Vocational_LPN, Nullable<bool> Nursing_Registered_BS_RN, Nullable<bool> Occupational_Therapy, Nullable<bool> Occupational_Therapy_Assisting, Nullable<bool> Office_Supervision_Management, Nullable<bool> Operations_Management_Supervision, Nullable<bool> Optometry_Pre_Optometry, Nullable<bool> Organizational_Behavior, Nullable<bool> Osteopathic_Medicine, Nullable<bool> Paralegal_Legal_Assistant, Nullable<bool> Parks_Recreation_Leisure_General, Nullable<bool> Parks_Rec_Leisure_Facilities_Management, Nullable<bool> Personal_Services_General, Nullable<bool> Pharmacy_Pre_Pharmacy, Nullable<bool> Philosophy, Nullable<bool> Photography, Nullable<bool> Physical_Education_Coaching, Nullable<bool> Physical_Sciences_General, Nullable<bool> Physical_Therapy_Pre_Physical_Therapy, Nullable<bool> Physical_Therapy_Assisting, Nullable<bool> Physician_Assisting, Nullable<bool> Physics, Nullable<bool> Political_Science_Government, Nullable<bool> Postsecondary_Education, Nullable<bool> Precision_Production_Trades_General, Nullable<bool> Protective_Services_General, Nullable<bool> Psychiatric_Mental_Health_Technician, Nullable<bool> Psychology_Clinical_Counseling, Nullable<bool> Psychology_General, Nullable<bool> Public_Administration, Nullable<bool> Public_Administration_Services_General, Nullable<bool> Public_Affairs_Public_Policy_Analysis, Nullable<bool> Public_Health, Nullable<bool> Public_Relations_Organizational_Communication, Nullable<bool> Public_Speaking, Nullable<bool> Purchasing_Procurement_Contracts_Management, Nullable<bool> Quality_Control_Safety_Technologies, Nullable<bool> Radio_Television_Broadcasting, Nullable<bool> Radio_Television_Broadcasting_Technology, Nullable<bool> Real_Estate, Nullable<bool> Rehabilitation_Therapy, Nullable<bool> Religion, Nullable<bool> Religious_Education, Nullable<bool> Respiratory_Therapy_Technology, Nullable<bool> Restaurant_Food_Services_Management, Nullable<bool> Sales_Merchandising_Marketing_General, Nullable<bool> Science_Education, Nullable<bool> Secondary_Education, Nullable<bool> Secretarial_Studies_Office_Administration, Nullable<bool> Small_Business_Management_Operations, Nullable<bool> Social_Sciences_General, Nullable<bool> Social_Studies_Sciences_Education, Nullable<bool> Social_Work, Nullable<bool> Sociology, Nullable<bool> Spanish_Language_Literature, Nullable<bool> Special_Education, Nullable<bool> Sport_Fitness_Administration_Management, Nullable<bool> Statistics, Nullable<bool> Surgical_Technology, Nullable<bool> Surveying_Technology, Nullable<bool> Teacher_Assisting_Aide_Education, Nullable<bool> Teacher_Education_General, Nullable<bool> Teacher_Education_Subject_Specific, Nullable<bool> Textile_Apparel, Nullable<bool> Theatre_Arts_Drama, Nullable<bool> Theology_General, Nullable<bool> Therapy_Rehabilitation_General, Nullable<bool> Tourism_Travel_Marketing, Nullable<bool> Transportation_Materials_Moving_e_g_air_ground_marine, Nullable<bool> Travel_Tourism_Management, Nullable<bool> Urban_Studies_Urban_Affairs, Nullable<bool> Veterinarian_Assisting_Technology, Nullable<bool> Veterinary_Medicine_Pre_Veterinarian, Nullable<bool> Vocational_Rehabilitation_Counseling, Nullable<bool> Webpage_Design, Nullable<bool> Welding_Technology, Nullable<bool> Wildlife_Wildlands_Management, Nullable<bool> Women_s_Studies, Nullable<bool> Zoology)
        {
            var data = db.UniversityInfoes.AsQueryable();
            if (!string.IsNullOrEmpty(TuitionDomUnderRange))
            {
                double? TuitionDomUnderMinimum = (double?)Double.Parse(TuitionDomUnderRange.Split(',')[0]);
                double? TuitionDomUnderMaximum = (double?)Double.Parse(TuitionDomUnderRange.Split(',')[1]);
                data = data.Where(x => (double?)x.Average_Domestic_Undergraduate_Cost_of_Tuition_per_semester >= TuitionDomUnderMinimum && (double?)x.Average_Domestic_Undergraduate_Cost_of_Tuition_per_semester <= TuitionDomUnderMaximum);
            }
            if (!string.IsNullOrEmpty(TuitionIntUnderRange))
            {
                double? TuitionIntUnderMinimum = (double?)Double.Parse(TuitionIntUnderRange.Split(',')[0]);
                double? TuitionIntUnderMaximum = (double?)Double.Parse(TuitionIntUnderRange.Split(',')[1]);
                data = data.Where(x => (double?)x.Average_International_Undergraduate_Cost_of_Tuition_per_semester >= TuitionIntUnderMinimum && (double?)x.Average_International_Undergraduate_Cost_of_Tuition_per_semester <= TuitionIntUnderMaximum);
            }
            if (!string.IsNullOrEmpty(TuitionDomPostRange))
            {
                double? TuitionDomPostMinimum = (double?)Double.Parse(TuitionDomPostRange.Split(',')[0]);
                double? TuitionDomPostMaximum = (double?)Double.Parse(TuitionDomPostRange.Split(',')[1]);
                data = data.Where(x => (double?)x.Average_Domestic_Postgraduate_Master_Cost_of_Tuition_per_semester >= TuitionDomPostMinimum && (double?)x.Average_Domestic_Postgraduate_Master_Cost_of_Tuition_per_semester <= TuitionDomPostMaximum);
            }
            if (!string.IsNullOrEmpty(TuitionIntPostRange))
            {
                double? TuitionIntPostMinimum = (double?)Double.Parse(TuitionIntPostRange.Split(',')[0]);
                double? TuitionIntPostMaximum = (double?)Double.Parse(TuitionIntPostRange.Split(',')[1]);
                data = data.Where(x => (double?)x.Average_International_Postgraduate_Master_Cost_of_Tuition_per_semester >= TuitionIntPostMinimum && (double?)x.Average_International_Postgraduate_Master_Cost_of_Tuition_per_semester <= TuitionIntPostMaximum);
            }
            if (!string.IsNullOrEmpty(CostOfLivingRange))
            {
                double? CostOfLivingMinimum = (double?)Double.Parse(CostOfLivingRange.Split(',')[0]);
                double? CostOfLivingMaximum = (double?)Double.Parse(CostOfLivingRange.Split(',')[1]);
                data = data.Where(x => (double?)x.Average_Cost_of_Living >= CostOfLivingMinimum && (double?)x.Average_Cost_of_Living <= CostOfLivingMaximum);
            }
            if (!string.IsNullOrEmpty(Country))
                data = data.Where(x => x.Address.Contains(Country));
            if (!string.IsNullOrEmpty(Type))
                data = data.Where(x => x.Type == Type);
            if (!string.IsNullOrEmpty(Campus_Setting))
                data = data.Where(x => x.Campus_Setting == Campus_Setting);
            if (!string.IsNullOrEmpty(Qualification_Type))
                data = data.Where(x => x.Qualification_Requirements.Contains(Qualification_Type));
            if (Accounting != null)
                data = data.Where(x => x.Accounting == true);
            if (Accounting_Technician != null)
                data = data.Where(x => x.Accounting_Technician == true);
            if (Actuarial_Science != null)
                data = data.Where(x => x.Actuarial_Science == true);
            if (Adult_Development_Aging_Gerontology != null)
                data = data.Where(x => x.Adult_Development_Aging_Gerontology == true);
            if (Advertising != null)
                data = data.Where(x => x.Advertising == true);
            if (Aeronautical_Astronautical_Engineering_Technologies != null)
                data = data.Where(x => x.Aeronautical_Astronautical_Engineering_Technologies == true);
            if (Aeronautical_Astronautical_Engineering != null)
                data = data.Where(x => x.Aeronautical_Astronautical_Engineering == true);
            if (African_American_Studies != null)
                data = data.Where(x => x.African_American_Studies == true);
            if (Agribusiness_Operations != null)
                data = data.Where(x => x.Agribusiness_Operations == true);
            if (Agricultural_Business_Management != null)
                data = data.Where(x => x.Agricultural_Business_Management == true);
            if (Agricultural_Economics != null)
                data = data.Where(x => x.Agricultural_Economics == true);
            if (Agricultural_Education != null)
                data = data.Where(x => x.Agricultural_Education == true);
            if (Agricultural_Mechanization != null)
                data = data.Where(x => x.Agricultural_Mechanization == true);
            if (Agricultural_Production != null)
                data = data.Where(x => x.Agricultural_Production == true);
            if (Agricultural_Bioengineering != null)
                data = data.Where(x => x.Agricultural_Bioengineering == true);
            if (Agriculture_General != null)
                data = data.Where(x => x.Agriculture_General == true);
            if (Agronomy_Crop_Science != null)
                data = data.Where(x => x.Agronomy_Crop_Science == true);
            if (Aircraft_Mechanics_Technology != null)
                data = data.Where(x => x.Aircraft_Mechanics_Technology == true);
            if (Aircraft_Piloting_Navigation != null)
                data = data.Where(x => x.Aircraft_Piloting_Navigation == true);
            if (Alcohol_Drug_Abuse_Counseling != null)
                data = data.Where(x => x.Alcohol_Drug_Abuse_Counseling == true);
            if (American_Indian_Native_American_Studies != null)
                data = data.Where(x => x.American_Indian_Native_American_Studies == true);
            if (American_English_Literature != null)
                data = data.Where(x => x.American_English_Literature == true);
            if (Animal_Sciences != null)
                data = data.Where(x => x.Animal_Sciences == true);
            if (Anthropology != null)
                data = data.Where(x => x.Anthropology == true);
            if (Applied_Mathematics != null)
                data = data.Where(x => x.Applied_Mathematics == true);
            if (Architectural_Drafting_CAD_Technology != null)
                data = data.Where(x => x.Architectural_Drafting_CAD_Technology == true);
            if (Architectural_Engineering != null)
                data = data.Where(x => x.Architectural_Engineering == true);
            if (Architectural_Engineering_Technology != null)
                data = data.Where(x => x.Architectural_Engineering_Technology == true);
            if (Architectural_Environmental_Design != null)
                data = data.Where(x => x.Architectural_Environmental_Design == true);
            if (Architecture_General != null)
                data = data.Where(x => x.Architecture_General == true);
            if (Area_Studies_General_e_g_African_Middle_Eastern != null)
                data = data.Where(x => x.Area_Studies_General_e_g_African_Middle_Eastern == true);
            if (Art_Education != null)
                data = data.Where(x => x.Art_Education == true);
            if (Art_History_Criticism_Conservation != null)
                data = data.Where(x => x.Art_History_Criticism_Conservation == true);
            if (Art_General != null)
                data = data.Where(x => x.Art_General == true);
            if (Asian_Area_Studies != null)
                data = data.Where(x => x.Asian_Area_Studies == true);
            if (Asian_Languages_Literatures != null)
                data = data.Where(x => x.Asian_Languages_Literatures == true);
            if (Astronomy != null)
                data = data.Where(x => x.Astronomy == true);
            if (Athletic_Training != null)
                data = data.Where(x => x.Athletic_Training == true);
            if (Atmospheric_Sciences_Meteorology != null)
                data = data.Where(x => x.Atmospheric_Sciences_Meteorology == true);
            if (Autobody_Repair_Technology != null)
                data = data.Where(x => x.Autobody_Repair_Technology == true);
            if (Automotive_Engineering_Technology != null)
                data = data.Where(x => x.Automotive_Engineering_Technology == true);
            if (Automotive_Mechanics_Technology != null)
                data = data.Where(x => x.Automotive_Mechanics_Technology == true);
            if (Aviation_Airway_Science_General != null)
                data = data.Where(x => x.Aviation_Airway_Science_General == true);
            if (Aviation_Management_Operations != null)
                data = data.Where(x => x.Aviation_Management_Operations == true);
            if (Avionics_Technology != null)
                data = data.Where(x => x.Avionics_Technology == true);
            if (Banking_Financial_Support_Services != null)
                data = data.Where(x => x.Banking_Financial_Support_Services == true);
            if (Bible_Biblical_Studies != null)
                data = data.Where(x => x.Bible_Biblical_Studies == true);
            if (Biochemistry_Biophysics != null)
                data = data.Where(x => x.Biochemistry_Biophysics == true);
            if (Biology_General != null)
                data = data.Where(x => x.Biology_General == true);
            if (Biomedical_Engineering != null)
                data = data.Where(x => x.Biomedical_Engineering == true);
            if (Business_Administration_Management_General != null)
                data = data.Where(x => x.Business_Administration_Management_General == true);
            if (Business_Education != null)
                data = data.Where(x => x.Business_Education == true);
            if (Business_Management_Quantitative_Methods_General != null)
                data = data.Where(x => x.Business_Management_Quantitative_Methods_General == true);
            if (Business_Managerial_Economics != null)
                data = data.Where(x => x.Business_Managerial_Economics == true);
            if (Career_Technical_Education != null)
                data = data.Where(x => x.Career_Technical_Education == true);
            if (Cell_Cellular_Biology != null)
                data = data.Where(x => x.Cell_Cellular_Biology == true);
            if (Chemical_Engineering != null)
                data = data.Where(x => x.Chemical_Engineering == true);
            if (Chemistry != null)
                data = data.Where(x => x.Chemistry == true);
            if (Child_Care_Services_Management != null)
                data = data.Where(x => x.Child_Care_Services_Management == true);
            if (Child_Development != null)
                data = data.Where(x => x.Child_Development == true);
            if (Chiropractic_Pre_Chiropractic != null)
                data = data.Where(x => x.Chiropractic_Pre_Chiropractic == true);
            if (Cinema_Film != null)
                data = data.Where(x => x.Cinema_Film == true);
            if (Cinematography_Film_Video_Production != null)
                data = data.Where(x => x.Cinematography_Film_Video_Production == true);
            if (City_Urban_Regional_Planning != null)
                data = data.Where(x => x.City_Urban_Regional_Planning == true);
            if (Civil_Engineering != null)
                data = data.Where(x => x.Civil_Engineering == true);
            if (Civil_Engineering_Technology != null)
                data = data.Where(x => x.Civil_Engineering_Technology == true);
            if (Classical_Ancient_Languages_Literatures != null)
                data = data.Where(x => x.Classical_Ancient_Languages_Literatures == true);
            if (Communication_Disorder_Services_e_g_Speech_Pathology != null)
                data = data.Where(x => x.Communication_Disorder_Services_e_g_Speech_Pathology == true);
            if (Communications_Technology_General != null)
                data = data.Where(x => x.Communications_Technology_General == true);
            if (Communications_General != null)
                data = data.Where(x => x.Communications_General == true);
            if (Community_Organization_Advocacy != null)
                data = data.Where(x => x.Community_Organization_Advocacy == true);
            if (Comparative_Literature != null)
                data = data.Where(x => x.Comparative_Literature == true);
            if (Computer_Information_Sciences_General != null)
                data = data.Where(x => x.Computer_Information_Sciences_General == true);
            if (Computer_Engineering != null)
                data = data.Where(x => x.Computer_Engineering == true);
            if (Computer_Engineering_Technology != null)
                data = data.Where(x => x.Computer_Engineering_Technology == true);
            if (Computer_Networking_Telecommunications != null)
                data = data.Where(x => x.Computer_Networking_Telecommunications == true);
            if (Computer_Science_Programming != null)
                data = data.Where(x => x.Computer_Science_Programming == true);
            if (Computer_Software_Media_Applications != null)
                data = data.Where(x => x.Computer_Software_Media_Applications == true);
            if (Computer_System_Administration != null)
                data = data.Where(x => x.Computer_System_Administration == true);
            if (Construction_Engineering_Management != null)
                data = data.Where(x => x.Construction_Engineering_Management == true);
            if (Construction_Trades_e_g_carpentry_plumbing_electrical != null)
                data = data.Where(x => x.Construction_Trades_e_g_carpentry_plumbing_electrical == true);
            if (Construction_Building_Technology != null)
                data = data.Where(x => x.Construction_Building_Technology == true);
            if (Consumer_Family_Economics != null)
                data = data.Where(x => x.Consumer_Family_Economics == true);
            if (Corrections != null)
                data = data.Where(x => x.Corrections == true);
            if (Cosmetology_Hairstyling != null)
                data = data.Where(x => x.Cosmetology_Hairstyling == true);
            if (Counseling_Student_Services != null)
                data = data.Where(x => x.Counseling_Student_Services == true);
            if (Court_Reporting != null)
                data = data.Where(x => x.Court_Reporting == true);
            if (Creative_Writing != null)
                data = data.Where(x => x.Creative_Writing == true);
            if (Criminal_Justice != null)
                data = data.Where(x => x.Criminal_Justice == true);
            if (Criminology != null)
                data = data.Where(x => x.Criminology == true);
            if (Culinary_Arts_Chef_Training != null)
                data = data.Where(x => x.Culinary_Arts_Chef_Training == true);
            if (Curriculum_Instruction != null)
                data = data.Where(x => x.Curriculum_Instruction == true);
            if (Dance != null)
                data = data.Where(x => x.Dance == true);
            if (Data_Management_Technology != null)
                data = data.Where(x => x.Data_Management_Technology == true);
            if (Dental_Assisting != null)
                data = data.Where(x => x.Dental_Assisting == true);
            if (Dental_Hygiene != null)
                data = data.Where(x => x.Dental_Hygiene == true);
            if (Dentistry_Pre_Dentistry != null)
                data = data.Where(x => x.Dentistry_Pre_Dentistry == true);
            if (Design_Visual_Communications_General != null)
                data = data.Where(x => x.Design_Visual_Communications_General == true);
            if (Diesel_Mechanics_Technology != null)
                data = data.Where(x => x.Diesel_Mechanics_Technology == true);
            if (Digital_Communications_Media != null)
                data = data.Where(x => x.Digital_Communications_Media == true);
            if (Divinity_Ministry != null)
                data = data.Where(x => x.Divinity_Ministry == true);
            if (Drafting_CAD_Technology_General != null)
                data = data.Where(x => x.Drafting_CAD_Technology_General == true);
            if (Early_Childhood_Education != null)
                data = data.Where(x => x.Early_Childhood_Education == true);
            if (Ecology != null)
                data = data.Where(x => x.Ecology == true);
            if (Economics != null)
                data = data.Where(x => x.Economics == true);
            if (Educational_Administration != null)
                data = data.Where(x => x.Educational_Administration == true);
            if (Electrical_Electronics_Communications_Engineering != null)
                data = data.Where(x => x.Electrical_Electronics_Communications_Engineering == true);
            if (Electrical_Electronics_Engineering_Technologies != null)
                data = data.Where(x => x.Electrical_Electronics_Engineering_Technologies == true);
            if (Electrical_Electronics_Equip_Installation_Repair != null)
                data = data.Where(x => x.Electrical_Electronics_Equip_Installation_Repair == true);
            if (Electromechanical_Biomedical_Engineering_Technologies != null)
                data = data.Where(x => x.Electromechanical_Biomedical_Engineering_Technologies == true);
            if (Elementary_Education != null)
                data = data.Where(x => x.Elementary_Education == true);
            if (Emergency_Medical_Technology != null)
                data = data.Where(x => x.Emergency_Medical_Technology == true);
            if (Engineering_Pre_Engineering_General != null)
                data = data.Where(x => x.Engineering_Pre_Engineering_General == true);
            if (Engineering_Technology_General != null)
                data = data.Where(x => x.Engineering_Technology_General == true);
            if (English_Language_Literature_General != null)
                data = data.Where(x => x.English_Language_Literature_General == true);
            if (English_Language_Arts_Education != null)
                data = data.Where(x => x.English_Language_Arts_Education == true);
            if (English_as_a_Second_Language_Education != null)
                data = data.Where(x => x.English_as_a_Second_Language_Education == true);
            if (Environmental_Control_Technologies != null)
                data = data.Where(x => x.Environmental_Control_Technologies == true);
            if (Environmental_Health_Engineering != null)
                data = data.Where(x => x.Environmental_Health_Engineering == true);
            if (Environmental_Science != null)
                data = data.Where(x => x.Environmental_Science == true);
            if (Ethnic_Minority_Studies_General != null)
                data = data.Where(x => x.Ethnic_Minority_Studies_General == true);
            if (European_Area_Studies != null)
                data = data.Where(x => x.European_Area_Studies == true);
            if (Exercise_Science_Physiology_Kinesiology != null)
                data = data.Where(x => x.Exercise_Science_Physiology_Kinesiology == true);
            if (Family_Consumer_Sciences_General != null)
                data = data.Where(x => x.Family_Consumer_Sciences_General == true);
            if (Fashion_Merchandising != null)
                data = data.Where(x => x.Fashion_Merchandising == true);
            if (Fashion_Apparel_Design != null)
                data = data.Where(x => x.Fashion_Apparel_Design == true);
            if (Finance_General != null)
                data = data.Where(x => x.Finance_General == true);
            if (Financial_Planning_Services != null)
                data = data.Where(x => x.Financial_Planning_Services == true);
            if (Fine_Studio_Arts != null)
                data = data.Where(x => x.Fine_Studio_Arts == true);
            if (Fire_Protection_Safety_Technology != null)
                data = data.Where(x => x.Fire_Protection_Safety_Technology == true);
            if (Food_Nutrition != null)
                data = data.Where(x => x.Food_Nutrition == true);
            if (Food_Sciences_Technology != null)
                data = data.Where(x => x.Food_Sciences_Technology == true);
            if (Foreign_Languages_Education != null)
                data = data.Where(x => x.Foreign_Languages_Education == true);
            if (Foreign_Languages_Literatures_General != null)
                data = data.Where(x => x.Foreign_Languages_Literatures_General == true);
            if (Forestry != null)
                data = data.Where(x => x.Forestry == true);
            if (French_Language_Literature != null)
                data = data.Where(x => x.French_Language_Literature == true);
            if (Funeral_Services_Mortuary_Science != null)
                data = data.Where(x => x.Funeral_Services_Mortuary_Science == true);
            if (Genetics != null)
                data = data.Where(x => x.Genetics == true);
            if (Geography != null)
                data = data.Where(x => x.Geography == true);
            if (Geological_Earth_Sciences != null)
                data = data.Where(x => x.Geological_Earth_Sciences == true);
            if (German_Language_Literature != null)
                data = data.Where(x => x.German_Language_Literature == true);
            if (Graphic_Printing_Equipment_Operation != null)
                data = data.Where(x => x.Graphic_Printing_Equipment_Operation == true);
            if (Graphic_Design != null)
                data = data.Where(x => x.Graphic_Design == true);
            if (Health_Physical_Education_Fitness != null)
                data = data.Where(x => x.Health_Physical_Education_Fitness == true);
            if (Health_Education != null)
                data = data.Where(x => x.Health_Education == true);
            if (Health_Services_Administration_General != null)
                data = data.Where(x => x.Health_Services_Administration_General == true);
            if (Health_Medical_Technology_General != null)
                data = data.Where(x => x.Health_Medical_Technology_General == true);
            if (Health_Related_Professions_Services_General != null)
                data = data.Where(x => x.Health_Related_Professions_Services_General == true);
            if (Heating_Air_Cond_Refrig_Install_Repair != null)
                data = data.Where(x => x.Heating_Air_Cond_Refrig_Install_Repair == true);
            if (History != null)
                data = data.Where(x => x.History == true);
            if (Horticulture_Operations_Management != null)
                data = data.Where(x => x.Horticulture_Operations_Management == true);
            if (Horticulture_Science != null)
                data = data.Where(x => x.Horticulture_Science == true);
            if (Hospital_Facilities_Administration != null)
                data = data.Where(x => x.Hospital_Facilities_Administration == true);
            if (Hotel_Motel_Management != null)
                data = data.Where(x => x.Hotel_Motel_Management == true);
            if (Human_Resources_Development_Training != null)
                data = data.Where(x => x.Human_Resources_Development_Training == true);
            if (Human_Resources_Management != null)
                data = data.Where(x => x.Human_Resources_Management == true);
            if (Industrial_Design != null)
                data = data.Where(x => x.Industrial_Design == true);
            if (Industrial_Engineering != null)
                data = data.Where(x => x.Industrial_Engineering == true);
            if (Industrial_Production_Technologies != null)
                data = data.Where(x => x.Industrial_Production_Technologies == true);
            if (Information_Science != null)
                data = data.Where(x => x.Information_Science == true);
            if (Insurance_Risk_Management != null)
                data = data.Where(x => x.Insurance_Risk_Management == true);
            if (Interior_Architecture != null)
                data = data.Where(x => x.Interior_Architecture == true);
            if (Interior_Design != null)
                data = data.Where(x => x.Interior_Design == true);
            if (International_Business_Management != null)
                data = data.Where(x => x.International_Business_Management == true);
            if (International_Relations_Affairs != null)
                data = data.Where(x => x.International_Relations_Affairs == true);
            if (Investments_Securities != null)
                data = data.Where(x => x.Investments_Securities == true);
            if (Journalism_Broadcast != null)
                data = data.Where(x => x.Journalism_Broadcast == true);
            if (Journalism_Print != null)
                data = data.Where(x => x.Journalism_Print == true);
            if (Junior_High_Middle_School_Education != null)
                data = data.Where(x => x.Junior_High_Middle_School_Education == true);
            if (Labor_Industrial_Relations != null)
                data = data.Where(x => x.Labor_Industrial_Relations == true);
            if (Landscape_Architecture != null)
                data = data.Where(x => x.Landscape_Architecture == true);
            if (Latin_American_Area_Studies != null)
                data = data.Where(x => x.Latin_American_Area_Studies == true);
            if (Latino_Chicano_Studies != null)
                data = data.Where(x => x.Latino_Chicano_Studies == true);
            if (Law_Pre_Law != null)
                data = data.Where(x => x.Law_Pre_Law == true);
            if (Law_Enforcement != null)
                data = data.Where(x => x.Law_Enforcement == true);
            if (Legal_Administrative_Assisting_Secretarial != null)
                data = data.Where(x => x.Legal_Administrative_Assisting_Secretarial == true);
            if (Legal_Studies_General != null)
                data = data.Where(x => x.Legal_Studies_General == true);
            if (Liberal_Arts_General_Studies != null)
                data = data.Where(x => x.Liberal_Arts_General_Studies == true);
            if (Library_Science != null)
                data = data.Where(x => x.Library_Science == true);
            if (Linguistics != null)
                data = data.Where(x => x.Linguistics == true);
            if (Logistics_Materials_Management != null)
                data = data.Where(x => x.Logistics_Materials_Management == true);
            if (Machine_Tool_Technology != null)
                data = data.Where(x => x.Machine_Tool_Technology == true);
            if (Management_Information_Systems != null)
                data = data.Where(x => x.Management_Information_Systems == true);
            if (Marine_Aquatic_Biology != null)
                data = data.Where(x => x.Marine_Aquatic_Biology == true);
            if (Marketing_Management_Research != null)
                data = data.Where(x => x.Marketing_Management_Research == true);
            if (Mass_Communications != null)
                data = data.Where(x => x.Mass_Communications == true);
            if (Massage_Therapy != null)
                data = data.Where(x => x.Massage_Therapy == true);
            if (Mathematics_Education != null)
                data = data.Where(x => x.Mathematics_Education == true);
            if (Mathematics_General != null)
                data = data.Where(x => x.Mathematics_General == true);
            if (Mechanical_Drafting_CAD_Technology != null)
                data = data.Where(x => x.Mechanical_Drafting_CAD_Technology == true);
            if (Mechanical_Engineering != null)
                data = data.Where(x => x.Mechanical_Engineering == true);
            if (Mechanical_Engineering_Technology != null)
                data = data.Where(x => x.Mechanical_Engineering_Technology == true);
            if (Mechanics_Repairers_General != null)
                data = data.Where(x => x.Mechanics_Repairers_General == true);
            if (Medical_Assisting != null)
                data = data.Where(x => x.Medical_Assisting == true);
            if (Medical_Laboratory_Technology != null)
                data = data.Where(x => x.Medical_Laboratory_Technology == true);
            if (Medical_Office_Secretarial != null)
                data = data.Where(x => x.Medical_Office_Secretarial == true);
            if (Medical_Radiologic_Technology != null)
                data = data.Where(x => x.Medical_Radiologic_Technology == true);
            if (Medical_Records != null)
                data = data.Where(x => x.Medical_Records == true);
            if (Medical_Clinical_Assisting_General != null)
                data = data.Where(x => x.Medical_Clinical_Assisting_General == true);
            if (Medicine_Pre_Medicine != null)
                data = data.Where(x => x.Medicine_Pre_Medicine == true);
            if (Mental_Health_Counseling != null)
                data = data.Where(x => x.Mental_Health_Counseling == true);
            if (Microbiology_Immunology != null)
                data = data.Where(x => x.Microbiology_Immunology == true);
            if (Middle_Eastern_Languages_Literatures != null)
                data = data.Where(x => x.Middle_Eastern_Languages_Literatures == true);
            if (Military_Technologies != null)
                data = data.Where(x => x.Military_Technologies == true);
            if (Multi_Interdisciplinary_Studies != null)
                data = data.Where(x => x.Multi_Interdisciplinary_Studies == true);
            if (Multimedia_Animation_Special_Effects != null)
                data = data.Where(x => x.Multimedia_Animation_Special_Effects == true);
            if (Music_Education != null)
                data = data.Where(x => x.Music_Education == true);
            if (Music_General != null)
                data = data.Where(x => x.Music_General == true);
            if (Music_Performance != null)
                data = data.Where(x => x.Music_Performance == true);
            if (Music_Theory_Composition != null)
                data = data.Where(x => x.Music_Theory_Composition == true);
            if (Natural_Resources_Conservation_General != null)
                data = data.Where(x => x.Natural_Resources_Conservation_General == true);
            if (Natural_Resources_Management != null)
                data = data.Where(x => x.Natural_Resources_Management == true);
            if (North_American_Area_Studies != null)
                data = data.Where(x => x.North_American_Area_Studies == true);
            if (Nuclear_Engineering != null)
                data = data.Where(x => x.Nuclear_Engineering == true);
            if (Nuclear_Medicine_Technology != null)
                data = data.Where(x => x.Nuclear_Medicine_Technology == true);
            if (Nursing_Practical_Vocational_LPN != null)
                data = data.Where(x => x.Nursing_Practical_Vocational_LPN == true);
            if (Nursing_Registered_BS_RN != null)
                data = data.Where(x => x.Nursing_Registered_BS_RN == true);
            if (Occupational_Therapy != null)
                data = data.Where(x => x.Occupational_Therapy == true);
            if (Occupational_Therapy_Assisting != null)
                data = data.Where(x => x.Occupational_Therapy_Assisting == true);
            if (Office_Supervision_Management != null)
                data = data.Where(x => x.Office_Supervision_Management == true);
            if (Operations_Management_Supervision != null)
                data = data.Where(x => x.Operations_Management_Supervision == true);
            if (Optometry_Pre_Optometry != null)
                data = data.Where(x => x.Optometry_Pre_Optometry == true);
            if (Organizational_Behavior != null)
                data = data.Where(x => x.Organizational_Behavior == true);
            if (Osteopathic_Medicine != null)
                data = data.Where(x => x.Osteopathic_Medicine == true);
            if (Paralegal_Legal_Assistant != null)
                data = data.Where(x => x.Paralegal_Legal_Assistant == true);
            if (Parks_Recreation_Leisure_General != null)
                data = data.Where(x => x.Parks_Recreation_Leisure_General == true);
            if (Parks_Rec_Leisure_Facilities_Management != null)
                data = data.Where(x => x.Parks_Rec_Leisure_Facilities_Management == true);
            if (Personal_Services_General != null)
                data = data.Where(x => x.Personal_Services_General == true);
            if (Pharmacy_Pre_Pharmacy != null)
                data = data.Where(x => x.Pharmacy_Pre_Pharmacy == true);
            if (Philosophy != null)
                data = data.Where(x => x.Philosophy == true);
            if (Photography != null)
                data = data.Where(x => x.Photography == true);
            if (Physical_Education_Coaching != null)
                data = data.Where(x => x.Physical_Education_Coaching == true);
            if (Physical_Sciences_General != null)
                data = data.Where(x => x.Physical_Sciences_General == true);
            if (Physical_Therapy_Pre_Physical_Therapy != null)
                data = data.Where(x => x.Physical_Therapy_Pre_Physical_Therapy == true);
            if (Physical_Therapy_Assisting != null)
                data = data.Where(x => x.Physical_Therapy_Assisting == true);
            if (Physician_Assisting != null)
                data = data.Where(x => x.Physician_Assisting == true);
            if (Physics != null)
                data = data.Where(x => x.Physics == true);
            if (Political_Science_Government != null)
                data = data.Where(x => x.Political_Science_Government == true);
            if (Postsecondary_Education != null)
                data = data.Where(x => x.Postsecondary_Education == true);
            if (Precision_Production_Trades_General != null)
                data = data.Where(x => x.Precision_Production_Trades_General == true);
            if (Protective_Services_General != null)
                data = data.Where(x => x.Protective_Services_General == true);
            if (Psychiatric_Mental_Health_Technician != null)
                data = data.Where(x => x.Psychiatric_Mental_Health_Technician == true);
            if (Psychology_Clinical_Counseling != null)
                data = data.Where(x => x.Psychology_Clinical_Counseling == true);
            if (Psychology_General != null)
                data = data.Where(x => x.Psychology_General == true);
            if (Public_Administration != null)
                data = data.Where(x => x.Public_Administration == true);
            if (Public_Administration_Services_General != null)
                data = data.Where(x => x.Public_Administration_Services_General == true);
            if (Public_Affairs_Public_Policy_Analysis != null)
                data = data.Where(x => x.Public_Affairs_Public_Policy_Analysis == true);
            if (Public_Health != null)
                data = data.Where(x => x.Public_Health == true);
            if (Public_Relations_Organizational_Communication != null)
                data = data.Where(x => x.Public_Relations_Organizational_Communication == true);
            if (Public_Speaking != null)
                data = data.Where(x => x.Public_Speaking == true);
            if (Purchasing_Procurement_Contracts_Management != null)
                data = data.Where(x => x.Purchasing_Procurement_Contracts_Management == true);
            if (Quality_Control_Safety_Technologies != null)
                data = data.Where(x => x.Quality_Control_Safety_Technologies == true);
            if (Radio_Television_Broadcasting != null)
                data = data.Where(x => x.Radio_Television_Broadcasting == true);
            if (Radio_Television_Broadcasting_Technology != null)
                data = data.Where(x => x.Radio_Television_Broadcasting_Technology == true);
            if (Real_Estate != null)
                data = data.Where(x => x.Real_Estate == true);
            if (Rehabilitation_Therapy != null)
                data = data.Where(x => x.Rehabilitation_Therapy == true);
            if (Religion != null)
                data = data.Where(x => x.Religion == true);
            if (Religious_Education != null)
                data = data.Where(x => x.Religious_Education == true);
            if (Respiratory_Therapy_Technology != null)
                data = data.Where(x => x.Respiratory_Therapy_Technology == true);
            if (Restaurant_Food_Services_Management != null)
                data = data.Where(x => x.Restaurant_Food_Services_Management == true);
            if (Sales_Merchandising_Marketing_General != null)
                data = data.Where(x => x.Sales_Merchandising_Marketing_General == true);
            if (Science_Education != null)
                data = data.Where(x => x.Science_Education == true);
            if (Secondary_Education != null)
                data = data.Where(x => x.Secondary_Education == true);
            if (Secretarial_Studies_Office_Administration != null)
                data = data.Where(x => x.Secretarial_Studies_Office_Administration == true);
            if (Small_Business_Management_Operations != null)
                data = data.Where(x => x.Small_Business_Management_Operations == true);
            if (Social_Sciences_General != null)
                data = data.Where(x => x.Social_Sciences_General == true);
            if (Social_Studies_Sciences_Education != null)
                data = data.Where(x => x.Social_Studies_Sciences_Education == true);
            if (Social_Work != null)
                data = data.Where(x => x.Social_Work == true);
            if (Sociology != null)
                data = data.Where(x => x.Sociology == true);
            if (Spanish_Language_Literature != null)
                data = data.Where(x => x.Spanish_Language_Literature == true);
            if (Special_Education != null)
                data = data.Where(x => x.Special_Education == true);
            if (Sport_Fitness_Administration_Management != null)
                data = data.Where(x => x.Sport_Fitness_Administration_Management == true);
            if (Statistics != null)
                data = data.Where(x => x.Statistics == true);
            if (Surgical_Technology != null)
                data = data.Where(x => x.Surgical_Technology == true);
            if (Surveying_Technology != null)
                data = data.Where(x => x.Surveying_Technology == true);
            if (Teacher_Assisting_Aide_Education != null)
                data = data.Where(x => x.Teacher_Assisting_Aide_Education == true);
            if (Teacher_Education_General != null)
                data = data.Where(x => x.Teacher_Education_General == true);
            if (Teacher_Education_Subject_Specific != null)
                data = data.Where(x => x.Teacher_Education_Subject_Specific == true);
            if (Textile_Apparel != null)
                data = data.Where(x => x.Textile_Apparel == true);
            if (Theatre_Arts_Drama != null)
                data = data.Where(x => x.Theatre_Arts_Drama == true);
            if (Theology_General != null)
                data = data.Where(x => x.Theology_General == true);
            if (Therapy_Rehabilitation_General != null)
                data = data.Where(x => x.Therapy_Rehabilitation_General == true);
            if (Tourism_Travel_Marketing != null)
                data = data.Where(x => x.Tourism_Travel_Marketing == true);
            if (Transportation_Materials_Moving_e_g_air_ground_marine != null)
                data = data.Where(x => x.Transportation_Materials_Moving_e_g_air_ground_marine == true);
            if (Travel_Tourism_Management != null)
                data = data.Where(x => x.Travel_Tourism_Management == true);
            if (Urban_Studies_Urban_Affairs != null)
                data = data.Where(x => x.Urban_Studies_Urban_Affairs == true);
            if (Veterinarian_Assisting_Technology != null)
                data = data.Where(x => x.Veterinarian_Assisting_Technology == true);
            if (Veterinary_Medicine_Pre_Veterinarian != null)
                data = data.Where(x => x.Veterinary_Medicine_Pre_Veterinarian == true);
            if (Vocational_Rehabilitation_Counseling != null)
                data = data.Where(x => x.Vocational_Rehabilitation_Counseling == true);
            if (Webpage_Design != null)
                data = data.Where(x => x.Webpage_Design == true);
            if (Welding_Technology != null)
                data = data.Where(x => x.Welding_Technology == true);
            if (Wildlife_Wildlands_Management != null)
                data = data.Where(x => x.Wildlife_Wildlands_Management == true);
            if (Women_s_Studies != null)
                data = data.Where(x => x.Women_s_Studies == true);
            if (Zoology != null)
                data = data.Where(x => x.Zoology == true);
            return View(data.ToList());
        }
        // GET: UniversityInfoes
        public ActionResult Index()
        {
            return View(db.UniversityInfoes.ToList());
        }

        // GET: UniversityInfoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UniversityInfo universityInfo = db.UniversityInfoes.Find(id);
            if (universityInfo == null)
            {
                return HttpNotFound();
            }
            return View(universityInfo);
        }

        // GET: UniversityInfoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UniversityInfoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Address,Average_Domestic_Undergraduate_Cost_of_Tuition_per_semester,Average_International_Undergraduate_Cost_of_Tuition_per_semester,Average_Domestic_Postgraduate_Master_Cost_of_Tuition_per_semester,Average_International_Postgraduate_Master_Cost_of_Tuition_per_semester,Average_Cost_of_Living,Type,Campus_Setting,QS_General_Ranking,Qualification_Requirements,Accounting,Accounting_Technician,Actuarial_Science,Adult_Development_Aging_Gerontology,Advertising,Aeronautical_Astronautical_Engineering_Technologies,Aeronautical_Astronautical_Engineering,African_American_Studies,Agribusiness_Operations,Agricultural_Business_Management,Agricultural_Economics,Agricultural_Education,Agricultural_Mechanization,Agricultural_Production,Agricultural_Bioengineering,Agriculture_General,Agronomy_Crop_Science,Aircraft_Mechanics_Technology,Aircraft_Piloting_Navigation,Alcohol_Drug_Abuse_Counseling,American_Indian_Native_American_Studies,American_English_Literature,Animal_Sciences,Anthropology,Applied_Mathematics,Architectural_Drafting_CAD_Technology,Architectural_Engineering,Architectural_Engineering_Technology,Architectural_Environmental_Design,Architecture_General,Area_Studies_General_e_g_African_Middle_Eastern,Art_Education,Art_History_Criticism_Conservation,Art_General,Asian_Area_Studies,Asian_Languages_Literatures,Astronomy,Athletic_Training,Atmospheric_Sciences_Meteorology,Autobody_Repair_Technology,Automotive_Engineering_Technology,Automotive_Mechanics_Technology,Aviation_Airway_Science_General,Aviation_Management_Operations,Avionics_Technology,Banking_Financial_Support_Services,Bible_Biblical_Studies,Biochemistry_Biophysics,Biology_General,Biomedical_Engineering,Business_Administration_Management_General,Business_Education,Business_Management_Quantitative_Methods_General,Business_Managerial_Economics,Career_Technical_Education,Cell_Cellular_Biology,Chemical_Engineering,Chemistry,Child_Care_Services_Management,Child_Development,Chiropractic_Pre_Chiropractic,Cinema_Film,Cinematography_Film_Video_Production,City_Urban_Regional_Planning,Civil_Engineering,Civil_Engineering_Technology,Classical_Ancient_Languages_Literatures,Communication_Disorder_Services_e_g_Speech_Pathology,Communications_Technology_General,Communications_General,Community_Organization_Advocacy,Comparative_Literature,Computer_Information_Sciences_General,Computer_Engineering,Computer_Engineering_Technology,Computer_Networking_Telecommunications,Computer_Science_Programming,Computer_Software_Media_Applications,Computer_System_Administration,Construction_Engineering_Management,Construction_Trades_e_g_carpentry_plumbing_electrical,Construction_Building_Technology,Consumer_Family_Economics,Corrections,Cosmetology_Hairstyling,Counseling_Student_Services,Court_Reporting,Creative_Writing,Criminal_Justice,Criminology,Culinary_Arts_Chef_Training,Curriculum_Instruction,Dance,Data_Management_Technology,Dental_Assisting,Dental_Hygiene,Dentistry_Pre_Dentistry,Design_Visual_Communications_General,Diesel_Mechanics_Technology,Digital_Communications_Media,Divinity_Ministry,Drafting_CAD_Technology_General,Early_Childhood_Education,Ecology,Economics,Educational_Administration,Electrical_Electronics_Communications_Engineering,Electrical_Electronics_Engineering_Technologies,Electrical_Electronics_Equip_Installation_Repair,Electromechanical_Biomedical_Engineering_Technologies,Elementary_Education,Emergency_Medical_Technology,Engineering_Pre_Engineering_General,Engineering_Technology_General,English_Language_Literature_General,English_Language_Arts_Education,English_as_a_Second_Language_Education,Environmental_Control_Technologies,Environmental_Health_Engineering,Environmental_Science,Ethnic_Minority_Studies_General,European_Area_Studies,Exercise_Science_Physiology_Kinesiology,Family_Consumer_Sciences_General,Fashion_Merchandising,Fashion_Apparel_Design,Finance_General,Financial_Planning_Services,Fine_Studio_Arts,Fire_Protection_Safety_Technology,Food_Nutrition,Food_Sciences_Technology,Foreign_Languages_Education,Foreign_Languages_Literatures_General,Forestry,French_Language_Literature,Funeral_Services_Mortuary_Science,Genetics,Geography,Geological_Earth_Sciences,German_Language_Literature,Graphic_Printing_Equipment_Operation,Graphic_Design,Health_Physical_Education_Fitness,Health_Education,Health_Services_Administration_General,Health_Medical_Technology_General,Health_Related_Professions_Services_General,Heating_Air_Cond_Refrig_Install_Repair,History,Horticulture_Operations_Management,Horticulture_Science,Hospital_Facilities_Administration,Hotel_Motel_Management,Human_Resources_Development_Training,Human_Resources_Management,Industrial_Design,Industrial_Engineering,Industrial_Production_Technologies,Information_Science,Insurance_Risk_Management,Interior_Architecture,Interior_Design,International_Business_Management,International_Relations_Affairs,Investments_Securities,Journalism_Broadcast,Journalism_Print,Junior_High_Middle_School_Education,Labor_Industrial_Relations,Landscape_Architecture,Latin_American_Area_Studies,Latino_Chicano_Studies,Law_Pre_Law,Law_Enforcement,Legal_Administrative_Assisting_Secretarial,Legal_Studies_General,Liberal_Arts_General_Studies,Library_Science,Linguistics,Logistics_Materials_Management,Machine_Tool_Technology,Management_Information_Systems,Marine_Aquatic_Biology,Marketing_Management_Research,Mass_Communications,Massage_Therapy,Mathematics_Education,Mathematics_General,Mechanical_Drafting_CAD_Technology,Mechanical_Engineering,Mechanical_Engineering_Technology,Mechanics_Repairers_General,Medical_Assisting,Medical_Laboratory_Technology,Medical_Office_Secretarial,Medical_Radiologic_Technology,Medical_Records,Medical_Clinical_Assisting_General,Medicine_Pre_Medicine,Mental_Health_Counseling,Microbiology_Immunology,Middle_Eastern_Languages_Literatures,Military_Technologies,Multi_Interdisciplinary_Studies,Multimedia_Animation_Special_Effects,Music_Education,Music_General,Music_Performance,Music_Theory_Composition,Natural_Resources_Conservation_General,Natural_Resources_Management,North_American_Area_Studies,Nuclear_Engineering,Nuclear_Medicine_Technology,Nursing_Practical_Vocational_LPN,Nursing_Registered_BS_RN,Occupational_Therapy,Occupational_Therapy_Assisting,Office_Supervision_Management,Operations_Management_Supervision,Optometry_Pre_Optometry,Organizational_Behavior,Osteopathic_Medicine,Paralegal_Legal_Assistant,Parks_Recreation_Leisure_General,Parks_Rec_Leisure_Facilities_Management,Personal_Services_General,Pharmacy_Pre_Pharmacy,Philosophy,Photography,Physical_Education_Coaching,Physical_Sciences_General,Physical_Therapy_Pre_Physical_Therapy,Physical_Therapy_Assisting,Physician_Assisting,Physics,Political_Science_Government,Postsecondary_Education,Precision_Production_Trades_General,Protective_Services_General,Psychiatric_Mental_Health_Technician,Psychology_Clinical_Counseling,Psychology_General,Public_Administration,Public_Administration_Services_General,Public_Affairs_Public_Policy_Analysis,Public_Health,Public_Relations_Organizational_Communication,Public_Speaking,Purchasing_Procurement_Contracts_Management,Quality_Control_Safety_Technologies,Radio_Television_Broadcasting,Radio_Television_Broadcasting_Technology,Real_Estate,Rehabilitation_Therapy,Religion,Religious_Education,Respiratory_Therapy_Technology,Restaurant_Food_Services_Management,Sales_Merchandising_Marketing_General,Science_Education,Secondary_Education,Secretarial_Studies_Office_Administration,Small_Business_Management_Operations,Social_Sciences_General,Social_Studies_Sciences_Education,Social_Work,Sociology,Spanish_Language_Literature,Special_Education,Sport_Fitness_Administration_Management,Statistics,Surgical_Technology,Surveying_Technology,Teacher_Assisting_Aide_Education,Teacher_Education_General,Teacher_Education_Subject_Specific,Textile_Apparel,Theatre_Arts_Drama,Theology_General,Therapy_Rehabilitation_General,Tourism_Travel_Marketing,Transportation_Materials_Moving_e_g_air_ground_marine,Travel_Tourism_Management,Urban_Studies_Urban_Affairs,Veterinarian_Assisting_Technology,Veterinary_Medicine_Pre_Veterinarian,Vocational_Rehabilitation_Counseling,Webpage_Design,Welding_Technology,Wildlife_Wildlands_Management,Women_s_Studies,Zoology")] UniversityInfo universityInfo)
        {
            if (ModelState.IsValid)
            {
                db.UniversityInfoes.Add(universityInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(universityInfo);
        }

        // GET: UniversityInfoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UniversityInfo universityInfo = db.UniversityInfoes.Find(id);
            if (universityInfo == null)
            {
                return HttpNotFound();
            }
            return View(universityInfo);
        }

        // POST: UniversityInfoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Address,Average_Domestic_Undergraduate_Cost_of_Tuition_per_semester,Average_International_Undergraduate_Cost_of_Tuition_per_semester,Average_Domestic_Postgraduate_Master_Cost_of_Tuition_per_semester,Average_International_Postgraduate_Master_Cost_of_Tuition_per_semester,Average_Cost_of_Living,Type,Campus_Setting,QS_General_Ranking,Qualification_Requirements,Accounting,Accounting_Technician,Actuarial_Science,Adult_Development_Aging_Gerontology,Advertising,Aeronautical_Astronautical_Engineering_Technologies,Aeronautical_Astronautical_Engineering,African_American_Studies,Agribusiness_Operations,Agricultural_Business_Management,Agricultural_Economics,Agricultural_Education,Agricultural_Mechanization,Agricultural_Production,Agricultural_Bioengineering,Agriculture_General,Agronomy_Crop_Science,Aircraft_Mechanics_Technology,Aircraft_Piloting_Navigation,Alcohol_Drug_Abuse_Counseling,American_Indian_Native_American_Studies,American_English_Literature,Animal_Sciences,Anthropology,Applied_Mathematics,Architectural_Drafting_CAD_Technology,Architectural_Engineering,Architectural_Engineering_Technology,Architectural_Environmental_Design,Architecture_General,Area_Studies_General_e_g_African_Middle_Eastern,Art_Education,Art_History_Criticism_Conservation,Art_General,Asian_Area_Studies,Asian_Languages_Literatures,Astronomy,Athletic_Training,Atmospheric_Sciences_Meteorology,Autobody_Repair_Technology,Automotive_Engineering_Technology,Automotive_Mechanics_Technology,Aviation_Airway_Science_General,Aviation_Management_Operations,Avionics_Technology,Banking_Financial_Support_Services,Bible_Biblical_Studies,Biochemistry_Biophysics,Biology_General,Biomedical_Engineering,Business_Administration_Management_General,Business_Education,Business_Management_Quantitative_Methods_General,Business_Managerial_Economics,Career_Technical_Education,Cell_Cellular_Biology,Chemical_Engineering,Chemistry,Child_Care_Services_Management,Child_Development,Chiropractic_Pre_Chiropractic,Cinema_Film,Cinematography_Film_Video_Production,City_Urban_Regional_Planning,Civil_Engineering,Civil_Engineering_Technology,Classical_Ancient_Languages_Literatures,Communication_Disorder_Services_e_g_Speech_Pathology,Communications_Technology_General,Communications_General,Community_Organization_Advocacy,Comparative_Literature,Computer_Information_Sciences_General,Computer_Engineering,Computer_Engineering_Technology,Computer_Networking_Telecommunications,Computer_Science_Programming,Computer_Software_Media_Applications,Computer_System_Administration,Construction_Engineering_Management,Construction_Trades_e_g_carpentry_plumbing_electrical,Construction_Building_Technology,Consumer_Family_Economics,Corrections,Cosmetology_Hairstyling,Counseling_Student_Services,Court_Reporting,Creative_Writing,Criminal_Justice,Criminology,Culinary_Arts_Chef_Training,Curriculum_Instruction,Dance,Data_Management_Technology,Dental_Assisting,Dental_Hygiene,Dentistry_Pre_Dentistry,Design_Visual_Communications_General,Diesel_Mechanics_Technology,Digital_Communications_Media,Divinity_Ministry,Drafting_CAD_Technology_General,Early_Childhood_Education,Ecology,Economics,Educational_Administration,Electrical_Electronics_Communications_Engineering,Electrical_Electronics_Engineering_Technologies,Electrical_Electronics_Equip_Installation_Repair,Electromechanical_Biomedical_Engineering_Technologies,Elementary_Education,Emergency_Medical_Technology,Engineering_Pre_Engineering_General,Engineering_Technology_General,English_Language_Literature_General,English_Language_Arts_Education,English_as_a_Second_Language_Education,Environmental_Control_Technologies,Environmental_Health_Engineering,Environmental_Science,Ethnic_Minority_Studies_General,European_Area_Studies,Exercise_Science_Physiology_Kinesiology,Family_Consumer_Sciences_General,Fashion_Merchandising,Fashion_Apparel_Design,Finance_General,Financial_Planning_Services,Fine_Studio_Arts,Fire_Protection_Safety_Technology,Food_Nutrition,Food_Sciences_Technology,Foreign_Languages_Education,Foreign_Languages_Literatures_General,Forestry,French_Language_Literature,Funeral_Services_Mortuary_Science,Genetics,Geography,Geological_Earth_Sciences,German_Language_Literature,Graphic_Printing_Equipment_Operation,Graphic_Design,Health_Physical_Education_Fitness,Health_Education,Health_Services_Administration_General,Health_Medical_Technology_General,Health_Related_Professions_Services_General,Heating_Air_Cond_Refrig_Install_Repair,History,Horticulture_Operations_Management,Horticulture_Science,Hospital_Facilities_Administration,Hotel_Motel_Management,Human_Resources_Development_Training,Human_Resources_Management,Industrial_Design,Industrial_Engineering,Industrial_Production_Technologies,Information_Science,Insurance_Risk_Management,Interior_Architecture,Interior_Design,International_Business_Management,International_Relations_Affairs,Investments_Securities,Journalism_Broadcast,Journalism_Print,Junior_High_Middle_School_Education,Labor_Industrial_Relations,Landscape_Architecture,Latin_American_Area_Studies,Latino_Chicano_Studies,Law_Pre_Law,Law_Enforcement,Legal_Administrative_Assisting_Secretarial,Legal_Studies_General,Liberal_Arts_General_Studies,Library_Science,Linguistics,Logistics_Materials_Management,Machine_Tool_Technology,Management_Information_Systems,Marine_Aquatic_Biology,Marketing_Management_Research,Mass_Communications,Massage_Therapy,Mathematics_Education,Mathematics_General,Mechanical_Drafting_CAD_Technology,Mechanical_Engineering,Mechanical_Engineering_Technology,Mechanics_Repairers_General,Medical_Assisting,Medical_Laboratory_Technology,Medical_Office_Secretarial,Medical_Radiologic_Technology,Medical_Records,Medical_Clinical_Assisting_General,Medicine_Pre_Medicine,Mental_Health_Counseling,Microbiology_Immunology,Middle_Eastern_Languages_Literatures,Military_Technologies,Multi_Interdisciplinary_Studies,Multimedia_Animation_Special_Effects,Music_Education,Music_General,Music_Performance,Music_Theory_Composition,Natural_Resources_Conservation_General,Natural_Resources_Management,North_American_Area_Studies,Nuclear_Engineering,Nuclear_Medicine_Technology,Nursing_Practical_Vocational_LPN,Nursing_Registered_BS_RN,Occupational_Therapy,Occupational_Therapy_Assisting,Office_Supervision_Management,Operations_Management_Supervision,Optometry_Pre_Optometry,Organizational_Behavior,Osteopathic_Medicine,Paralegal_Legal_Assistant,Parks_Recreation_Leisure_General,Parks_Rec_Leisure_Facilities_Management,Personal_Services_General,Pharmacy_Pre_Pharmacy,Philosophy,Photography,Physical_Education_Coaching,Physical_Sciences_General,Physical_Therapy_Pre_Physical_Therapy,Physical_Therapy_Assisting,Physician_Assisting,Physics,Political_Science_Government,Postsecondary_Education,Precision_Production_Trades_General,Protective_Services_General,Psychiatric_Mental_Health_Technician,Psychology_Clinical_Counseling,Psychology_General,Public_Administration,Public_Administration_Services_General,Public_Affairs_Public_Policy_Analysis,Public_Health,Public_Relations_Organizational_Communication,Public_Speaking,Purchasing_Procurement_Contracts_Management,Quality_Control_Safety_Technologies,Radio_Television_Broadcasting,Radio_Television_Broadcasting_Technology,Real_Estate,Rehabilitation_Therapy,Religion,Religious_Education,Respiratory_Therapy_Technology,Restaurant_Food_Services_Management,Sales_Merchandising_Marketing_General,Science_Education,Secondary_Education,Secretarial_Studies_Office_Administration,Small_Business_Management_Operations,Social_Sciences_General,Social_Studies_Sciences_Education,Social_Work,Sociology,Spanish_Language_Literature,Special_Education,Sport_Fitness_Administration_Management,Statistics,Surgical_Technology,Surveying_Technology,Teacher_Assisting_Aide_Education,Teacher_Education_General,Teacher_Education_Subject_Specific,Textile_Apparel,Theatre_Arts_Drama,Theology_General,Therapy_Rehabilitation_General,Tourism_Travel_Marketing,Transportation_Materials_Moving_e_g_air_ground_marine,Travel_Tourism_Management,Urban_Studies_Urban_Affairs,Veterinarian_Assisting_Technology,Veterinary_Medicine_Pre_Veterinarian,Vocational_Rehabilitation_Counseling,Webpage_Design,Welding_Technology,Wildlife_Wildlands_Management,Women_s_Studies,Zoology")] UniversityInfo universityInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(universityInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(universityInfo);
        }

        // GET: UniversityInfoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UniversityInfo universityInfo = db.UniversityInfoes.Find(id);
            if (universityInfo == null)
            {
                return HttpNotFound();
            }
            return View(universityInfo);
        }

        // POST: UniversityInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UniversityInfo universityInfo = db.UniversityInfoes.Find(id);
            db.UniversityInfoes.Remove(universityInfo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
