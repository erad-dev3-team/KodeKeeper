using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KodeKeeper
{
	class fileDataObject
	{
		private int			_id				= -1;
		private int			_projectId		= -1;
		private string		_project		= "";
		private string		_fileName		= "";
		private string		_location		= "";
		private int			_fileTypeId		= -1;
		private string		_fileType		= "";
		private string		_fileVersion	= "";
		private bool		_inUse			= false;
		private string		_parameters		= "";
		private string		_fileContents	= "";
		private long		_fileSize		= -1;
		private string		_notes			= "";
		private int			_rights			= -1;
		private string		_owner			= "";
		private string		_group			= "";
		private DateTime	_added			= default(DateTime);
		private DateTime	_modified		= default(DateTime);
		private string		_comment		= "";

		public fileDataObject(int Id, int ProjectId, string Project, string FileName, string Location, int FileTypeId, string FileType, string FileVersion, bool InUse, string Parameters, string FileContents, long FileSize, string Notes, int Rights, string Owner, string Group, DateTime Added, DateTime Modified, string Comment)
		{
			_id				= Id;
			_projectId		= ProjectId;
			_project		= Project;
			_fileName		= FileName;
			_location		= Location;
			_fileTypeId		= FileTypeId;
			_fileType		= FileType;
			_fileVersion	= FileVersion;
			_inUse			= InUse;
			_parameters		= Parameters;
			_fileContents	= FileContents;
			_fileSize		= FileSize;
			_notes			= Notes;
			_rights			= Rights;
			_owner			= Owner;
			_group			= Group;
			_added			= Added;
			_modified		= Modified;
			_comment		= Comment;
		}
	}
}
