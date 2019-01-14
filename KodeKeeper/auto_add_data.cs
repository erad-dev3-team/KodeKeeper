using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KodeKeeper
{
	public static class auto_add_data
	{
		public static string _imageInsert = Properties.Resources.ImageInsert;

		public static string _filetypeInsert =
								"INSERT INTO filetypes																																											\r\n" +
								"(type,		description,					mime_type,																	def_image_id,													comment)\r\n" +
								"VALUES																																															\r\n" +
								"('pl',		'Perl script file',				'text/x-script.perl',														(SELECT id FROM images WHERE name='perl_1_256' 		),			''),	\r\n" +
								"('pm',		'Perl module',					'text/x-script.perl-module',												(SELECT id FROM images WHERE name='perl_2_256' 		),			''),	\r\n" +
								"('php',	'PHP script file',				'text/x-php',																(SELECT id FROM images WHERE name='php_2_256' 		),			''),	\r\n" +
								"('css',	'CSS stylesheet file',			'text/css',																	(SELECT id FROM images WHERE name='css_1_256' 		),			''),	\r\n" +
								"('html',	'Html file',					'text/html',																(SELECT id FROM images WHERE name='html_1_256' 		),			''),	\r\n" +
								"('txt',	'Plaintext file',				'text/plain',																(SELECT id FROM images WHERE name='text_1_256' 		),			''),	\r\n" +
								"('pdf',	'Portable Data Format file',	'application/pdf',															(SELECT id FROM images WHERE name='pdf_256' 		),			''),	\r\n" +
								"('jpeg',	'Jpeg image',					'image/jpeg',																(SELECT id FROM images WHERE name='image_256' 		),			''),	\r\n" +
								"('png',	'Png image',					'image/png',																(SELECT id FROM images WHERE name='image_256' 		),			''),	\r\n" +
								"('java',	'Java file',					'text/x-java-source',														(SELECT id FROM images WHERE name='java_1_256' 		),			''),	\r\n" +
								"('jar',	'Java archive file',			'application/java-archive',													(SELECT id FROM images WHERE name='java_2_256' 		),			''),	\r\n" +
								"('js',		'Javascript file',				'text/javascript',															(SELECT id FROM images WHERE name='js_256' 			),			''),	\r\n" +
								"('zip',	'Zip archive',					'application/zip',															(SELECT id FROM images WHERE name='zip_256' 		),			''),	\r\n" +
								"('tar',	'Tar archive',					'application/tar',															(SELECT id FROM images WHERE name='zip_256' 		),			''),	\r\n" +
								"('tar.gz',	'Tar gzip archive',				'application/tar+gzip',														(SELECT id FROM images WHERE name='zip_256' 		),			''),	\r\n" +
								"('jrxml',	'iReport jrxml file',			'application/jrxml',														(SELECT id FROM images WHERE name='report_1_256' 	),			''),	\r\n" +
								"('jasper',	'iReport jasper file',			'application/octet-stream',													(SELECT id FROM images WHERE name='report_2_256' 	),			''),	\r\n" +
								"('doc',	'Microsoft Word doc file',		'application/msword',														(SELECT id FROM images WHERE name='word_4_256' 		),			''),	\r\n" +
								"('docx',	'Microsoft Word docx file',		'application/vnd.openxmlformats-officedocument.wordprocessingml.document',	(SELECT id FROM images WHERE name='word_1_256' 		),			''),	\r\n" +
								"('ppt',	'Microsoft Powerpoint ppt file','application/powerpoint',													(SELECT id FROM images WHERE name='ppt_1_256' 		),			''),	\r\n" +
								"('xls',	'Microsoft Excel xls file',		'application/vnd.ms-excel',													(SELECT id FROM images WHERE name='excel_3_256' 	),			''),	\r\n" +
								"('xlsx',	'Microsoft Excel xlsx file',	'application/vnd.openxmlformats-officedocument.spreadsheetml.sheet',		(SELECT id FROM images WHERE name='excel_1_256' 	),			''),	\r\n" +
								"('xml',	'XML markup file',				'text/xml',																	(SELECT id FROM images WHERE name='xml_256' 		),			''),	\r\n" +
								"('sqlite',	'SQLite database file',			'application/x-sqlite3',													(SELECT id FROM images WHERE name='sqlite_1_256' 	),			''),	\r\n" +
								"('log',	'Plaintext log file',			'text/plain',																(SELECT id FROM images WHERE name='log_256' 		),			''),	\r\n" +
								"('dir',	'Directory',					'text/directory',															(SELECT id FROM images WHERE name='dir_1_256' 		),			'');	\r\n";

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
