# Project Description

System.Net.FtpClient is a client implementation of the FTP protocol that is designed to
be easy to use and easy to extend. Aside from normal FTP client features, it supports
SSL/TLS connections for command and data channels and parsing various file listing formats.
This project is being developed with C#.

Information

Please read over the documentation page before writing any code. There is important
information there that will help you along the way. There is an API reference included with
the downloads that contains examples as well however the Documentation page on this site
covers implementation details and best practices that are based on peoples experiences, not
just my own, in an effort to help ensure this project works well for your needs.

For those interested, System.Net.FtpClient is now available via nuget. The nuget package
contains a release build of the library, the associated source code, the examples project,
and the compiled help API reference. This package will be updated and pushed up to nuget.org
with every future release.

# Features

* Explicit and Implicit SSL connections for the control and data connections using .net's SslStream
* Support for adding client certificates (please read the documentation page!)
* File listing parsers for various formats
  * UNIX long listings
  * Machine listings
  * IIS DOS listings
  * Ability to add your own parsers
* Passive and Active data connections (PASV, EPSV, PORT and EPRT)
* Support for DrFTPD's (non-standard) PRET command
* Returns Stream objects for reading or writing files on the server
* Attempts to make the FTP protocol safer with threads by cloning the control
  connection for file transfers (can be disabled)
  * Implements its own internal locking in an effort to keep transactions synchronized
* Implements the IAsyncResult pattern for almost all methods
* Includes support for non-standard hashing/checksum commands when supported by the server
* Examples included in documentation and as source code for nearly all methods
* Easily issue any command using the Execute() method with the exception of those requiring
  a data connection (file listings and transfers).
* Transaction logging using TraceListeners (passwords are automatically omitted)
* DLL's are built for .net 4 and .net 2 however I only test against .net 4 (see the documentation page)

What's not supported? Well there are some legacy systems out there such as VAX that are
not supported however they are still usable with some work on your part.
System.Net.FtpClient assumes the FTP server it's talking to supports UNIX style paths
which is the biggest problem when dealing with these types of systems. There is a file
listing parser included for VAX systems but it isn't supported, use it at your own risk.
Ultimately, I do not have access to such a system to test and debug against so I can't
support them.

# Bugs

In order to get help and in turn help others by getting bugs fixed please use the
discussions section where we can talk and try to get to the bottom of any problems.
If you're fairly certain you've found a bug in the System.Net.FtpClient code then make
a detailed bug report in the Issue Tracker. It's worth taking a look over the Source Code
section and reading the commit comments to see if a particular bug has already been
addressed in a newer revision than what you might be using. Please do not use the release
reviews to post about errors. If you want to leave a bad review then that is your prerogative
but if you want to report an error do so through the proper channels so that we can discuss
the problem in a public manner that helps everyone.

When you encounter a bug there are a few important things that you can include that will
go a long way in helping to resolve the matter. Aside from a good description of how to
reproduce the problem, include with your report the transaction log, the exact revision
number, and the exact version of the server OS and ftp software tat you were connected
to when the problem occurred. I realize that some of this information may not be available
but if it is please be sure to include it.

Refer to [`Examples\Debug.cs`](https://github.com/FubarDevelopment/netftp/blob/master/Examples/Debug.cs)
for information on how to easily log the server transactions. The information provided
is very valuable when tracking down the source of problems.

If you are having trouble opening the CHM, right click on it, select properties and
choose "Un-block" from the General Tab. If you don't trust us and don't want to unblock
the file then download the source code and dig through the Examples project which
includes all of the examples used in the CHM.
