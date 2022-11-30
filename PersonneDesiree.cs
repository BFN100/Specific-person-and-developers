using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POOII_BFN
{
    public class PersonneDesiree : VerificationAge
    {
        private int age;
        private string sexe;
        private string pays_origine;
        private string couleur_cheveau;
        private string couleur_yeux;
        private string education;

        public PersonneDesiree(int age, string sexe, string pays_origine, string couleur_cheveau, string couleur_yeux, string education)
        {
            this.age = Verification_Age(age);
            this.sexe = sexe;
            this.pays_origine = pays_origine;
            this.couleur_cheveau = couleur_cheveau;
            this.couleur_yeux = couleur_yeux;
            this.education = education;
        }

        public int getAge() { return this.Verification_Age(age); }
        public string getSexe() { return this.sexe; } 
        public string getPays_origine() { return this.pays_origine; }
        public string getCouleur_cheveau() { return this.couleur_cheveau; }
        public string getCouleur_yeux() { return this.couleur_yeux; }
        public string getEducation() { return this.education; }


        public class Builder   
        {

            private int age;
            private string sexe;
            private string pays_origine;
            private string couleur_cheveau;
            private string couleur_yeux;
            private string education;

            
            public Builder WithAge(int age)
            {
                this.age = age;
                return this;
            }
            public Builder WithSexe(string sexe)
            {
                this.sexe = sexe;
                return this;
            }
            public Builder WithPays(string pays_origine)
            {
                this.pays_origine = pays_origine;
                return this;
            }
            public Builder WithCheveu(string couleur_cheveau)
            {
                this.couleur_cheveau = couleur_cheveau;
                return this;
            }
            public Builder WithYeux(string couleur_yeux)
            {
                this.couleur_yeux = couleur_yeux;
                return this;
            }
            public Builder WithEducation(string education)
            {
                this.education = education;
                return this;
            }


            public PersonneDesiree Build()
            {
                return new PersonneDesiree(this);
            }

            
            public int getAge() { return this.age; }
            public string getSexe() { return this.sexe; }
            public string getPays_origine() { return this.pays_origine; }
            public string getCouleur_cheveau() { return this.couleur_cheveau; }
            public string getCouleur_yeux() { return this.couleur_yeux; }
            public string getEducation() { return this.education; }
        }

        private PersonneDesiree(Builder b)
        { 
            this.age = b.getAge();
            this.sexe = b.getSexe();
            this.pays_origine = b.getPays_origine();
            this.couleur_cheveau = b.getCouleur_cheveau();
            this.couleur_yeux = b.getCouleur_yeux();
            this.education = b.getEducation();
        }

        
    }
}
