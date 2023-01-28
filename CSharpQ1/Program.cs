using System.Collections;

public class School{
    private String schoolName, location, district, province, privateInstitution, rank;

    public String getSchoolName(){
        return this.schoolName;
    }

    public void setSchoolName(String schoolName){
        this.schoolName = schoolName;
    }

    public String getLocation(){
        return this.location;
    }

    public void setLocation(String location){
        this.location = location;
    }

    public String getDistrict(){
        return this.district;
    }

    public void setDistrict(String district){
        this.district = district;
    }

    public String getProvince(){
        return this.province;
    }

    public void setProvince(String province){
        this.province = province;
    }

    public String getPrivateInstitution(){
        return this.privateInstitution;
    }

    public void setPrivateInstitution(String privateInstitution){
        this.privateInstitution = privateInstitution;
    }

    /*public String setRank{
        get{ return rank;}
        set{
            if(value == "1" || value == "2" || value == "3"){
                value = rank;
            } else {
                rank = "Not Ranked";
            }
        }
    }*/

    public String getRank(){
        return this.rank;
    }

    public void setRank(String rank){
        if(rank == "1" || rank == "2" || rank == "3"){
            this.rank = rank;
        } else {
            rank = "Not Ranked";
        }
    }

    public School(String schoolName, String location, String district, String province, String privateInstitution, String rank){
            this.setSchoolName(schoolName);
            this.setLocation(location);
            this.setDistrict(district);
            this.setProvince(province);
            this.setPrivateInstitution(privateInstitution);
            this.setRank(rank);
        }

        public virtual String Print(){
        return getSchoolName() + getLocation() + getDistrict() + getProvince() + getPrivateInstitution() + getRank();
    }
}

public class College : School{
    private String type;

    public College(String schoolName, String location, String district, String province, String privateInstitution, String rank, String type) : base(schoolName, location, district, province, privateInstitution, rank){
        this.setType(type);
    }

    public String getType(){
        return this.type;
    }

    public void setType(String type){
        this.type = type;
    }

    public override String Print(){
        return getSchoolName() + getLocation() + getDistrict() + getProvince() + getPrivateInstitution() + getRank() + getType();
    }
}

public class University : School{
    private String rating;

    public University(String schoolName, String location, String district, String province, String privateInstitution, String rank, String rating) : base(schoolName, location, district, province, privateInstitution, rank){
        setRating(rating);
    }

    public String getRating(){
        return this.rating;
    }

    public void setRating(String rating){
        this.rating = rating;
    }

    public override String Print(){
        return getSchoolName() + getLocation() + getDistrict() + getProvince() + getPrivateInstitution() + getRank() + getRating();
    }
}

class Program{
    public static void Main(string[] args){

        School school1 = new School("Merebank Secondary, ", "Merebank, ", "Durban, ", "KwaZulu-Natal, ", "Private, ", "1");
        School school2 = new School("Ganges Secondary, ", "Chatsworth, ", "Johannesburg, ", "Gauteng, ", "Public, ", "2");
        School school3 = new School("Fairvale Secondary, ", "Crossmoore, ", "Cape Town, ", "Western Cape, ", "Private, ", "3");
        
        College college1 = new College("Roodeport College, ", "Chatsworth, ", "Johannesburg, ", "Gauteng, ", "Public, ", "2, ", "Distant");
        College college2 = new College("Manhattan College, ", "Merebank, ", "Durban, ", "KwaZulu-Natal, ", "Public, ", "1, ", "Contact");
        College college3 = new College("Rosebank College, ", "Neelsworth, ", "Cape Town, ", "Western Cape, ", "Private, ", "3, ", "Distant, ");

        University university1 = new University("UNISA, ", "Moordrive, ", "Cape Town, ", "Western Cape, ", "Public, ", "3, ", "4/5 stars");
        University university2 = new University("UKZN, ", "Smithdrive, ", "Johannesburg, ", "Gauteng, ", "Private, ", "2, ", "2/5 stars");
        University university3 = new University("DUT, ", "Charlesdrive, ", "Durban, ", "KwaZulu-Natal, ", "Public, ", "1, ", "3/5 stars");
        
        ArrayList Obj = new ArrayList();
        Obj.Add(school1.Print());
        Obj.Add(school2.Print());
        Obj.Add(school3.Print());
        Obj.Add("--------------------------------------------------------------------------");
        Obj.Add(college1.Print());
        Obj.Add(college2.Print());
        Obj.Add(college3.Print());
        Obj.Add("--------------------------------------------------------------------------");
        Obj.Add(university1.Print());
        Obj.Add(university2.Print());
        Obj.Add(university3.Print());

        foreach (var obj in Obj){
            Console.WriteLine();
            Console.WriteLine(obj);
        }

    }
}