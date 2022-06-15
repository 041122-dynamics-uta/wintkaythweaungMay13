using System.Collections;
using System.Data;
using System.Text;
using  System.Collections.ObjectModel; 
using System.Data.SqlClient;
using Model;
using DataAccess;

namespace BusinessLogic;
public class MemberBL:IMemberBL

{    
   // save for rewriting code without help from comipler
    private IRepository  _repo;

    public MemberBL(IRepository p_repo) 
     
    {

        this._repo=r;
    }

    public Member AddMember(Member p_member)
    {
        return _repo.AddMember(p_member);
    }
    public Member UpdateMember(Member p_member)
    {
        return _repo.UpdateMemeber(p_member);
    }
    public List<Member>GetMemberByName(string p_Name)
    {
        List<Member>lsitMember= _repo.GetAllCustomer();
        var searchname=lsitMember(p=> p.Name.Contains(p_Name));
        if(searchname !=null)
        {
            return lsitMember.where(Member => Member.Name.Contains(p_Name)).Tolist();
        }
        else
        {
            throw new System.Exception ("This member can't be found");
        }

    }

    public List<Member>GetMemberByEmail(string p_Email)
    {
        List<Member>listMember=_repo.GetAllCustomer();
        
        return m1;
    }

    public List<Customer> GetAllCustomer()
    {
        return _repo.GetAllCustomer();
    }


    public async Task<List<Customer>> GetAllCustomerAsync()
    {
        return await _repo.GetAllCustomerAsync();
    }


    
        
  }
     



 








