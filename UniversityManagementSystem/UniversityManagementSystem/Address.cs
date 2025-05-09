namespace UniversityManagementSystem;

public class Address
{
    public string Street { get; set; }
    public string City   { get; set; }
    public string State  { get; set; }
    public string Zip    { get; set; }

    public override string ToString() => $"{Street}, {City}, {State} {Zip}";
}
