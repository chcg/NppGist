﻿using NppPluginNET;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NppGist
{
	public class Lists
	{
		public static char[] InvalidFilenameCharacters = Path.GetInvalidFileNameChars();

		public static char[] ControlChars = new char[] {
			(char)1, // Ctrl + A
			(char)3, // Ctrl + C
			(char)22, // Ctrl + V
			(char)24, // Ctrl + X
			(char)Keys.Back // Backspace
		};

		public static Dictionary<string, LangType> GistNppLangs = new Dictionary<string, LangType>()
		{
			{ "Text", LangType.L_TEXT },
			{ "PHP", LangType.L_PHP },
			{ "C", LangType.L_C },
			{ "C++", LangType.L_CPP },
			{ "C#", LangType.L_CS },
			{ "Objective-C", LangType.L_OBJC },
			{ "JAVA", LangType.L_JAVA },
			//{ "", LangType.L_RC },
			{ "HTML", LangType.L_HTML },
			{ "HTML+Django", LangType.L_HTML },
			{ "HTML+ERB", LangType.L_HTML },
			{ "HTML+PHP", LangType.L_HTML },
			{ "RHTML", LangType.L_HTML },
			{ "XML", LangType.L_XML },
			{ "Makefile", LangType.L_MAKEFILE },
			{ "Pascal", LangType.L_PASCAL },
			{ "Batchfile", LangType.L_BATCH },
			{ "INI", LangType.L_INI },
			{ "AsciiDoc", LangType.L_ASCII },
			//{"", LangType.L_USER },
			{ "ASP", LangType.L_ASP },
			{ "SQL", LangType.L_SQL },
			{ "Visual Basic", LangType.L_VB },
			{ "BlitzBasic", LangType.L_VB },
			{ "RealBasic", LangType.L_VB },
			{ "JavaScript", LangType.L_JS },
			{ "JSON", LangType.L_JS },
			{ "JSON5", LangType.L_JS },
			{ "CSS", LangType.L_CSS },
			{ "Perl", LangType.L_PERL },
			{ "Perl6", LangType.L_PERL },
			{ "Python", LangType.L_PYTHON },
			{ "Lua", LangType.L_LUA },
			{ "TeX", LangType.L_TEX },
			{ "FORTRAN", LangType.L_FORTRAN },
			//{ "", LangType.L_BASH },
			{ "ActionScript", LangType.L_FLASH },
			{ "NSIS", LangType.L_NSIS },
			{ "Tcl", LangType.L_TCL },
			{ "Common Lisp", LangType.L_LISP },
			{ "Emacs Lisp", LangType.L_LISP },
			{ "Scheme", LangType.L_SCHEME },
			{ "Assembly", LangType.L_ASM },
			{ "Parrot Assembly", LangType.L_ASM },
			{ "DCPU-16 ASM", LangType.L_ASM },
			{ "Diff", LangType.L_DIFF },
			//{ "", LangType.L_PROPS },
			{ "PostScript", LangType.L_PS },
			{ "Ruby", LangType.L_RUBY },
			{ "Ragel in Ruby Host", LangType.L_RUBY },
			{ "Smalltalk", LangType.L_SMALLTALK },
			{ "VHDL", LangType.L_VHDL },
			//{ "", LangType.L_KIX },
			{ "AutoIt", LangType.L_AU3 },
			{ "OCaml", LangType.L_CAML },
			{ "Ada", LangType.L_ADA },
			{ "Verilog", LangType.L_VERILOG },
			{ "Matlab", LangType.L_MATLAB },
			{ "Haskell", LangType.L_HASKELL },
			{ "Inno Setup", LangType.L_INNO },
			//{ "", LangType.L_SEARCHRESULT },
			{ "CMake", LangType.L_CMAKE },
			{ "YAML", LangType.L_YAML },
			{ "COBOL", LangType.L_COBOL },
			//{ "", LangType.L_GUI4CLI },
			{ "D", LangType.L_D },
			{ "PowerShell", LangType.L_POWERSHELL },
			{ "R", LangType.L_R },
			{ "Java Server Pages", LangType.L_JSP },
			{ "CoffeeScript", LangType.L_EXTERNAL },
		};

		public static List<string> GistLangs = new List<string>()
		{
			"Text",
			"ActionScript",
			"C",
			"C#",
			"C++",
			"Clojure",
			"CoffeeScript",
			"Common Lisp",
			"CSS",
			"Diff",
			"Emacs Lisp",
			"Erlang",
			"Haskell",
			"HTML",
			"Java",
			"JavaScript",
			"Lua",
			"Objective-C",
			"Perl",
			"PHP",
			"Python",
			"Ruby",
			"Scala",
			"Scheme",
			"SQL",
			"ABAP",
			"Ada",
			"Agda",
			"ANTLR",
			"ApacheConf",
			"Apex",
			"AppleScript",
			"Arc",
			"Arduino",
			"AsciiDoc",
			"ASP",
			"Assembly",
			"Augeas",
			"AutoHotkey",
			"AutoIt",
			"Awk",
			"Batchfile",
			"Befunge",
			"BlitzBasic",
			"BlitzMax",
			"Bluespec",
			"Boo",
			"Brainfuck",
			"Brightscript",
			"Bro",
			"C-ObjDump",
			"C2hs Haskell",
			"Ceylon",
			"ChucK",
			"Clean",
			"CLIPS",
			"CMake",
			"COBOL",
			"ColdFusion",
			"Coq",
			"Cpp-ObjDump",
			"Creole",
			"Crystal",
			"Cucumber",
			"Cuda",
			"Cython",
			"D",
			"D-ObjDump",
			"Darcs Patch",
			"Dart",
			"DCPU-16 ASM",
			"DM",
			"DOT",
			"Dylan",
			"eC",
			"Ecere Projects",
			"ECL",
			"edn",
			"Eiffel",
			"Elixir",
			"Elm",
			"F#",
			"Factor",
			"Fancy",
			"Fantom",
			"fish",
			"Forth",
			"FORTRAN",
			"GAS",
			"Genshi",
			"Gentoo Ebuild",
			"Gentoo Eclass",
			"Gettext Catalog",
			"GLSL",
			"Glyph",
			"Go",
			"Gosu",
			"Groff",
			"Groovy",
			"Groovy Server Pages",
			"Haml",
			"Handlebars",
			"Harbour",
			"Haxe",
			"HTML+Django",
			"HTML+ERB",
			"HTML+PHP",
			"HTTP",
			"Hy",
			"IDL",
			"Idris",
			"INI",
			"Inno Setup",
			"Io",
			"Ioke",
			"IRC log",
			"J",
			"Jade",
			"Java Server Pages",
			"JSON",
			"JSON5",
			"Julia",
			"Kotlin",
			"KRL",
			"Lasso",
			"Less",
			"LFE",
			"LilyPond",
			"Literate Agda",
			"Literate CoffeeScript",
			"Literate Haskell",
			"LiveScript",
			"LLVM",
			"Logos",
			"Logtalk",
			"M",
			"Makefile",
			"Mako",
			"Markdown",
			"Matlab",
			"Max",
			"MediaWiki",
			"MiniD",
			"Mirah",
			"Monkey",
			"Moocode",
			"MoonScript",
			"mupad",
			"Myghty",
			"Nemerle",
			"nesC",
			"NetLogo",
			"Nginx",
			"Nimrod",
			"NSIS",
			"Nu",
			"NumPy",
			"ObjDump",
			"Objective-J",
			"OCaml",
			"Omgrofl",
			"ooc",
			"Opa",
			"OpenCL",
			"OpenEdge ABL",
			"Org",
			"Oxygene",
			"Parrot",
			"Parrot Assembly",
			"Parrot Internal Representation",
			"Pascal",
			"PAWN",
			"Perl6",
			"Pike",
			"Pod",
			"PogoScript",
			"PostScript",
			"PowerShell",
			"Processing",
			"Prolog",
			"Protocol Buffer",
			"Puppet",
			"Pure Data",
			"Python traceback",
			"QML",
			"R",
			"Racket",
			"Ragel in Ruby Host",
			"Raw token data",
			"RDoc",
			"REALbasic",
			"Rebol",
			"Redcode",
			"reStructuredText",
			"RHTML",
			"RMarkdown",
			"RobotFramework",
			"Rouge",
			"Rust",
			"Sage",
			"Sass",
			"Scaml",
			"Scilab",
			"SCSS",
			"Self",
			"Shell",
			"Slash",
			"Smalltalk",
			"Smarty",
			"Squirrel",
			"Standard ML",
			"Stylus",
			"SuperCollider",
			"Tcl",
			"Tcsh",
			"Tea",
			"TeX",
			"Textile",
			"TOML",
			"Turing",
			"Twig",
			"TXL",
			"TypeScript",
			"Unified Parallel C",
			"UnrealScript",
			"Vala",
			"Verilog",
			"VHDL",
			"VimL",
			"Visual Basic",
			"Volt",
			"wisp",
			"xBase",
			"XC",
			"XML",
			"XProc",
			"XQuery",
			"XS",
			"XSLT",
			"Xtend",
			"YAML",
		};
	}
}
