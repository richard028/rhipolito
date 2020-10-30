using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Membership
{
    class Membership
    {
        static void Main(string[] args)
        {

            List<membership> memberfile = new List<membership>();
            memberfile.Add(new membership("Arcris", "Navotas City", "1", "32", "M"));
            memberfile.Add(new membership("Ronny", "Manila City", "2", "27", "M"));
            memberfile.Add(new membership("Richard", "Caloocan City", "21", "19", "M"));
            memberfile.Add(new membership("Ryan", "Malabon City", "4", "24", "M"));
            memberfile.Add(new membership("Romeo", "Navotas City", "5", "19", "M"));
            int c = 1;
            while (c == 1) //Para MaContinue//
            {
                Console.WriteLine("Choose:\n1.Prints names and addresses of each member\n2.Input Adress and Print Names living in the City.\n3.Prints the address of a specific member\n4.Add a member\n5.Remove and Update list\n");
                
                int e = 0;
                while (e == 0)//Para Kapag Invalid Choice//
                {
                    Console.WriteLine("Enter the number of your choice:");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 1)
                    {
                        returnAllNameAddress();
                        e++;
                    }
                    else if (choice == 2)
                    {
                        returnNameCity();
                        e++;
                    }
                    else if (choice == 3)
                    {
                        returnAddressOfName();
                        e++;
                    }
                    else if (choice == 4)
                    {
                        addNewMember();
                        e++;
                    }
                    else if (choice == 5)
                    {
                        updateMembers();
                        e++;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Choice. Enter Again.");
                    }
                }
                //METHODS//
                void returnAllNameAddress()
                {
                    Console.WriteLine("LIST OF ALL MEMBER'S NAMES AND THEIR ADDRESSES: ");
                    foreach (membership member in memberfile)
                    {
                        Console.WriteLine("Name: {0}\tAddress: {1}", member.Name, member.Address);
                    }
                }
                void returnNameCity()
                {
                    foreach (membership member in memberfile)
                    {
                        Console.WriteLine("List of Cities: {0}", member.Address);
                    }
                    int a = 0;
                    while (a == 0)//Para sa Invalid City//
                    {
                        Console.WriteLine("Enter City: ");
                        string area = Console.ReadLine();
                        Console.WriteLine("List of Name/s living in this City: ");
                        foreach (membership member in memberfile)
                        {

                            if (area == member.Address)
                            {
                                Console.WriteLine("Name: {0}", member.Name);
                                a++;
                            }
                        }
                        if (a == 0)
                        {
                            Console.WriteLine("Invalid City, Input Again");
                        }
                        else
                        {
                            a = 1;
                        }
                    }
                }
                void returnAddressOfName()
                {

                    foreach (membership member in memberfile)
                    {
                        Console.WriteLine("Name: {0}", member.Name);
                    }
                    int b = 0;
                    while (b == 0)
                    {
                        Console.WriteLine("Enter Name: ");
                        String name = Console.ReadLine();
                        foreach (membership member in memberfile)
                        {
                            if (name == member.Name)
                            {
                                Console.WriteLine("Name: {0}\tAddress: {1}", member.Name, member.Address);
                                b++;
                            }
                        }
                        if (b == 0)
                        {
                            Console.WriteLine("Name not found!\nEnter Name Again. ");
                        }
                        else
                        {
                            b = 1;
                        }
                    }
                }
                void addNewMember()
                {
                    Console.WriteLine("ADDING MEMBER: \n");
                    Console.WriteLine("Enter Name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter Address: ");
                    string address = Console.ReadLine();
                    Console.WriteLine("Enter Contact Number: ");
                    string contact = Console.ReadLine();
                    Console.WriteLine("Enter Age: ");
                    string age = Console.ReadLine();
                    Console.WriteLine("Enter Sex: ");
                    string sex = Console.ReadLine();
                    memberfile.Add(new membership(name, address, contact, age, sex));
                    Console.WriteLine("Updated List: \n");
                    foreach (membership member in memberfile)
                    {
                        Console.WriteLine("Name: {0} \tAddress: {1} \tContact Number: {2} \tAge: {3} \tSex: {4}", member.Name, member.Address, member.Contact, member.Age,member.Sex);
                    }
                }
                void updateMembers()
                {
                    Console.WriteLine("Deleting MEMBER: \n");
                    foreach (membership member in memberfile)
                    {
                        Console.WriteLine("Name: {0}", member.Name);
                    }
                    int f = 0;
                    while (f == 0)//Para sa Invalid Name//
                    {
                        Console.WriteLine("Enter Name: ");
                        string name = Console.ReadLine();
                        var itemToRemove = memberfile.Find(x => x.Name == name);
                        memberfile.Remove(itemToRemove);
                        if (itemToRemove == null)
                        {
                            Console.WriteLine("Name not Found !");
                        }
                        else
                        {
                            Console.WriteLine("Updated List: \n");
                            foreach (membership member in memberfile)
                            {
                                Console.WriteLine("Name: {0} \tAddress: {1} \tContact Number: {2} \tAge: {3} \tSex: {4}", member.Name, member.Address, member.Contact, member.Age, member.Sex);
                                f++;
                            }
                        }
                    }
                }
                Console.WriteLine("Enter 'y' to continue and 'n' to exit");
                string d = Console.ReadLine();
                if (d != "y")
                {
                    c++;
                }
            }
        }
    }
}
