using ShopPro.Class.Exceptions;
using System;
using System.Data;

namespace ShopPro.Class.Entities
{
    public class Category
    {
        #region "Atributos"
        private int _categoryid;
        private string? _categoryname;
        private string? _description;
        private DateTime _creation_date;
        private int _creation_user;
        private DateTime? _modify_date;
        private int? _modify_user;
        private int? _delete_user;
        private DateTime? _delete_date;
        private bool _deleted;
        #endregion

        #region "Propiedades"


        public int CategoryId
        {
            get { return _categoryid; }
            set { _categoryid = value; }
        }

        public string? CategoryName
        {
            get { return _categoryname; }
            set 
            {


                if (string.IsNullOrEmpty(value))
                    throw new CategoryException("El nombre es requerido.");

                if (value.Length > 200)
                    throw new CategoryException("La longitud del nombre es inválido.");

                _categoryname = value; 
            }
        }
        public string? Description
        {
            get { return _description; }
            set
            {

                if (string.IsNullOrEmpty(value))
                    throw new CategoryException("La descripción es requerida.");

                if (value.Length > 200)
                    throw new CategoryException("La longitud de la descripción es inválida.");
               
                
                _description = value;
            }
        }
        public DateTime CreationDate
        {
            get { return _creation_date; }
            set { _creation_date = value; }
        }
        public int CreationUser
        {
            get { return _creation_user; }
            set { _creation_user = value; }
        }

        public int? ModifyUser
        {
            get { return _modify_user; }
            set { _modify_user = value; }
        }

        public DateTime? ModifyDate
        {
            get { return _modify_date; }
            set { _modify_date = value; }
        }

        public int? DeleteUser
        {
            get { return _delete_user; }
            set { _delete_user = value; }
        }

        public DateTime? DeleteDate
        {
            get { return _delete_date; }
            set { _delete_date = value; }
        }
        public bool Deleted
        {
            get { return _deleted; }
            set { _deleted = value; }
        }

        #endregion
    }
}
