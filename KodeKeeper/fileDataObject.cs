using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KodeKeeper
{
	class fileDataObject
	{
		public int		Id				= -1;					//Generated Locally
		public int		FileUID			= -1;					//Generated on the server and queried after upload
		public int		ProjectId		= -1;					//Local
		public string	Project			= "";					//Local (by id)
		public string	FileName		= "";					//Local
		public string	Location		= "";					//Location of file on server
		public string	md5ID			= "";					//Generated Locally (Project_id, File_name, File_path, File_type_id)
		public string	FilePath		= "";					//Path of file attached
		public int		FileTypeId		= -1;					//Local
		public string	FileTypeName	= "";					//Local (by id)
		public int		FileImageId		= -1;					//Local (by name)
		public string	FileImageName	= "";					//Local
		public string	FileVersion		= "";					//Local
		public bool		InUse			= false;				//Local
		public string	Parameters		= "";					//Local
		public string	FileContents	= "";					//Local
		public long		FileSize		= -1;					//Generated Locally (from file)
		public long		UploadedBy		= -1;					//Local (by name)
		public string	UploadUserName	= "";					//Local
		public string	Notes			= "";					//Local
		public string	Rights			= "";					//Local
		public string	Owner			= "";					//Local
		public string	Group			= "";					//Local
		public DateTime	Created			= default(DateTime);	//Local
		public DateTime	Modified		= default(DateTime);	//Local
		public DateTime	UploadDateTime	= default(DateTime);	//Generated Locally
		public string	Comment			= "";					//Local

		public fileDataObject()
		{

		}
	}
}
