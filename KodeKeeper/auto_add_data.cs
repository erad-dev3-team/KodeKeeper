using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KodeKeeper
{
	public static class auto_add_data
	{
		public static string _imageInsert = Properties.Resources.ImageInsert;

		public static string _filetypeInsert = "--Default FileTypes List																																						" +
								"INSERT INTO filetypes																																											" +
								"(type,		description,					mime_type,																	def_image,														comment)" +
								"VALUES																																															" +
								"('pl',		'Perl script file',				'text/x-script.perl',														(SELECT id FROM images WHERE name='perl_1_256';		),			''),	" +
								"('pm',		'Perl module',					'text/x-script.perl-module',												(SELECT id FROM images WHERE name='perl_2_256';		),			''),	" +
								"('php',	'PHP script file',				'text/x-php',																(SELECT id FROM images WHERE name='php_2_256';		),			''),	" +
								"('css',	'CSS stylesheet file',			'text/css',																	(SELECT id FROM images WHERE name='css_1_256';		),			''),	" +
								"('html',	'Html file',					'text/html',																(SELECT id FROM images WHERE name='html_1_256';		),			''),	" +
								"('txt',	'Plaintext file',				'text/plain',																(SELECT id FROM images WHERE name='text_1_256';		),			''),	" +
								"('pdf',	'Portable Data Format file',	'application/pdf',															(SELECT id FROM images WHERE name='pdf_256';		),			''),	" +
								"('jpeg',	'Jpeg image',					'image/jpeg',																(SELECT id FROM images WHERE name='image_256';		),			''),	" +
								"('png',	'Png image',					'image/png',																(SELECT id FROM images WHERE name='image_256';		),			''),	" +
								"('java',	'Java file',					'text/x-java-source',														(SELECT id FROM images WHERE name='java_1_256';		),			''),	" +
								"('jar',	'Java archive file',			'application/java-archive',													(SELECT id FROM images WHERE name='java_2_256';		),			''),	" +
								"('js',		'Javascript file',				'text/javascript',															(SELECT id FROM images WHERE name='js_256';			),			''),	" +
								"('zip',	'Zip archive',					'application/zip',															(SELECT id FROM images WHERE name='zip_256';		),			''),	" +
								"('tar',	'Tar archive',					'application/tar',															(SELECT id FROM images WHERE name='zip_256';		),			''),	" +
								"('tar.gz',	'Tar gzip archive',				'application/tar+gzip',														(SELECT id FROM images WHERE name='zip_256';		),			''),	" +
								"('jrxml',	'iReport jrxml file',			'application/jrxml',														(SELECT id FROM images WHERE name='report_1_256';	),			''),	" +
								"('jasper',	'iReport jasper file',			'application/octet-stream',													(SELECT id FROM images WHERE name='report_2_256';	),			''),	" +
								"('doc',	'Microsoft Word doc file',		'application/msword',														(SELECT id FROM images WHERE name='word_4_256';		),			''),	" +
								"('docx',	'Microsoft Word docx file',		'application/vnd.openxmlformats-officedocument.wordprocessingml.document',	(SELECT id FROM images WHERE name='word_1_256';		),			''),	" +
								"('ppt',	'Microsoft Powerpoint ppt file','application/powerpoint',													(SELECT id FROM images WHERE name='ppt_1_256';		),			''),	" +
								"('xls',	'Microsoft Excel xls file',		'application/vnd.ms-excel',													(SELECT id FROM images WHERE name='excel_3_256';	),			''),	" +
								"('xlsx',	'Microsoft Excel xlsx file',	'application/vnd.openxmlformats-officedocument.spreadsheetml.sheet',		(SELECT id FROM images WHERE name='excel_1_256';	),			''),	" +
								"('xml',	'XML markup file',				'text/xml',																	(SELECT id FROM images WHERE name='xml_256';		),			''),	" +
								"('sqlite',	'SQLite database file',			'application/x-sqlite3',													(SELECT id FROM images WHERE name='sqlite_1_256';	),			''),	" +
								"('log',	'Plaintext log file',			'text/plain',																(SELECT id FROM images WHERE name='log_256';		),			''),	" +
								"('dir',	'Directory',					'text/directory',															(SELECT id FROM images WHERE name='dir_1_256';		),			'');	";

		public static string autoAddImages()
		{
			return _imageInsert;
		}

		public static string autoAddFileTypes()
		{
			return _filetypeInsert;
		}

	}
}
