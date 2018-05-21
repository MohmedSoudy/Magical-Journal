/*
* MATLAB Compiler: 6.2 (R2016a)
* Date: Sun Apr 29 18:30:58 2018
* Arguments: "-B" "macro_default" "-W" "dotnet:BonusMain,Bonus,0.0,private" "-T"
* "link:lib" "-d" "G:\mohmed\Fourth year\Second Term\Image
* Processing\MagicalJournal\BonusMain\for_testing" "-v" "class{Bonus:G:\mohmed\Fourth
* year\Second Term\Image Processing\Magical Newspaper\Project Functions\BonusMain.m}" 
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace BonusMainNative
{

  /// <summary>
  /// The Bonus class provides a CLS compliant, Object (native) interface to the MATLAB
  /// functions contained in the files:
  /// <newpara></newpara>
  /// G:\mohmed\Fourth year\Second Term\Image Processing\Magical Newspaper\Project
  /// Functions\BonusMain.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class Bonus : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Runtime instance.
    /// </summary>
    static Bonus()
    {
      if (MWMCR.MCRAppInitialized)
      {
        try
        {
          Assembly assembly= Assembly.GetExecutingAssembly();

          string ctfFilePath= assembly.Location;

          int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

          ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

          string ctfFileName = "BonusMain.ctf";

          Stream embeddedCtfStream = null;

          String[] resourceStrings = assembly.GetManifestResourceNames();

          foreach (String name in resourceStrings)
          {
            if (name.Contains(ctfFileName))
            {
              embeddedCtfStream = assembly.GetManifestResourceStream(name);
              break;
            }
          }
          mcr= new MWMCR("",
                         ctfFilePath, embeddedCtfStream, true);
        }
        catch(Exception ex)
        {
          ex_ = new Exception("MWArray assembly failed to be initialized", ex);
        }
      }
      else
      {
        ex_ = new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the Bonus class.
    /// </summary>
    public Bonus()
    {
      if(ex_ != null)
      {
        throw ex_;
      }
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~Bonus()
    {
      Dispose(false);
    }


    /// <summary>
    /// Frees the native resources associated with this object
    /// </summary>
    public void Dispose()
    {
      Dispose(true);

      GC.SuppressFinalize(this);
    }


    /// <summary internal= "true">
    /// Internal dispose function
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
      if (!disposed)
      {
        disposed= true;

        if (disposing)
        {
          // Free managed resources;
        }

        // Free native resources
      }
    }


    #endregion Finalize

    #region Methods

    /// <summary>
    /// Provides a void output, 0-input Objectinterface to the BonusMain MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    ///
    public void BonusMain()
    {
      mcr.EvaluateFunction(0, "BonusMain", new Object[]{});
    }


    /// <summary>
    /// Provides a void output, 1-input Objectinterface to the BonusMain MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="Image_Path">Input argument #1</param>
    ///
    public void BonusMain(Object Image_Path)
    {
      mcr.EvaluateFunction(0, "BonusMain", Image_Path);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the BonusMain MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] BonusMain(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "BonusMain", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the BonusMain MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Image_Path">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] BonusMain(int numArgsOut, Object Image_Path)
    {
      return mcr.EvaluateFunction(numArgsOut, "BonusMain", Image_Path);
    }


    /// <summary>
    /// Provides an interface for the BonusMain function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("BonusMain", 1, 0, 0)]
    protected void BonusMain(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("BonusMain", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }

    /// <summary>
    /// This method will cause a MATLAB figure window to behave as a modal dialog box.
    /// The method will not return until all the figure windows associated with this
    /// component have been closed.
    /// </summary>
    /// <remarks>
    /// An application should only call this method when required to keep the
    /// MATLAB figure window from disappearing.  Other techniques, such as calling
    /// Console.ReadLine() from the application should be considered where
    /// possible.</remarks>
    ///
    public void WaitForFiguresToDie()
    {
      mcr.WaitForFiguresToDie();
    }



    #endregion Methods

    #region Class Members

    private static MWMCR mcr= null;

    private static Exception ex_= null;

    private bool disposed= false;

    #endregion Class Members
  }
}
