﻿namespace Ex41_InterfaceSegregationPrinciple.Audi
{

    public abstract class AudiA5 : Audi
    {
        public AudiA5(string model, string brand) 
            : base(model, brand) { }
    }
}
