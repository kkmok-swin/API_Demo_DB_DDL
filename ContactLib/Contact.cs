using System;

namespace ContactLib
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }

        public Organisation Org { get; set; }
}

public class Organisation {

public string OrgName { get; set; }

public string Notes { get; set; }
}
