/*
* MATLAB Compiler: 6.6 (R2018a)
* Date: Fri Apr 12 09:43:15 2019
* Arguments:
* "-B""macro_default""-W""dotnet:Clustering,cluster,4.0,private""-T""link:lib""-d""D:\Goog
* le Drive\Research\Grasshopper Plugin Scan-to-BIM\Clustering\Matlab
* Library\Clustering\for_testing""-v""class{cluster:D:\Google Drive\Research\Grasshopper
* Plugin Scan-to-BIM\Clustering\Matlab\G_CRF_wall_decoding.m}"
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace ClusteringNative
{

  /// <summary>
  /// The cluster class provides a CLS compliant, Object (native) interface to the MATLAB
  /// functions contained in the files:
  /// <newpara></newpara>
  /// D:\Google Drive\Research\Grasshopper Plugin
  /// Scan-to-BIM\Clustering\Matlab\G_CRF_wall_decoding.m
  /// </summary>
  /// <remarks>
  /// @Version 4.0
  /// </remarks>
  public class cluster : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Runtime instance.
    /// </summary>
    static cluster()
    {
      if (MWMCR.MCRAppInitialized)
      {
        try
        {
          Assembly assembly= Assembly.GetExecutingAssembly();

          string ctfFilePath= assembly.Location;

          int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

          ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

          string ctfFileName = "Clustering.ctf";

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
    /// Constructs a new instance of the cluster class.
    /// </summary>
    public cluster()
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
    ~cluster()
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
    /// Provides a single output, 0-input Objectinterface to the G_CRF_wall_decoding
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// #function UGM_Decode_ICM UGM_makeEdgeStruct
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object G_CRF_wall_decoding()
    {
      return mcr.EvaluateFunction("G_CRF_wall_decoding", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the G_CRF_wall_decoding
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// #function UGM_Decode_ICM UGM_makeEdgeStruct
    /// </remarks>
    /// <param name="nStates">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object G_CRF_wall_decoding(Object nStates)
    {
      return mcr.EvaluateFunction("G_CRF_wall_decoding", nStates);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the G_CRF_wall_decoding
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// #function UGM_Decode_ICM UGM_makeEdgeStruct
    /// </remarks>
    /// <param name="nStates">Input argument #1</param>
    /// <param name="fn1">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object G_CRF_wall_decoding(Object nStates, Object fn1)
    {
      return mcr.EvaluateFunction("G_CRF_wall_decoding", nStates, fn1);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the G_CRF_wall_decoding
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// #function UGM_Decode_ICM UGM_makeEdgeStruct
    /// </remarks>
    /// <param name="nStates">Input argument #1</param>
    /// <param name="fn1">Input argument #2</param>
    /// <param name="fn2">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object G_CRF_wall_decoding(Object nStates, Object fn1, Object fn2)
    {
      return mcr.EvaluateFunction("G_CRF_wall_decoding", nStates, fn1, fn2);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the G_CRF_wall_decoding
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// #function UGM_Decode_ICM UGM_makeEdgeStruct
    /// </remarks>
    /// <param name="nStates">Input argument #1</param>
    /// <param name="fn1">Input argument #2</param>
    /// <param name="fn2">Input argument #3</param>
    /// <param name="fe1">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object G_CRF_wall_decoding(Object nStates, Object fn1, Object fn2, Object fe1)
    {
      return mcr.EvaluateFunction("G_CRF_wall_decoding", nStates, fn1, fn2, fe1);
    }


    /// <summary>
    /// Provides a single output, 5-input Objectinterface to the G_CRF_wall_decoding
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// #function UGM_Decode_ICM UGM_makeEdgeStruct
    /// </remarks>
    /// <param name="nStates">Input argument #1</param>
    /// <param name="fn1">Input argument #2</param>
    /// <param name="fn2">Input argument #3</param>
    /// <param name="fe1">Input argument #4</param>
    /// <param name="fe2">Input argument #5</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object G_CRF_wall_decoding(Object nStates, Object fn1, Object fn2, Object fe1, 
                                Object fe2)
    {
      return mcr.EvaluateFunction("G_CRF_wall_decoding", nStates, fn1, fn2, fe1, fe2);
    }


    /// <summary>
    /// Provides a single output, 6-input Objectinterface to the G_CRF_wall_decoding
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// #function UGM_Decode_ICM UGM_makeEdgeStruct
    /// </remarks>
    /// <param name="nStates">Input argument #1</param>
    /// <param name="fn1">Input argument #2</param>
    /// <param name="fn2">Input argument #3</param>
    /// <param name="fe1">Input argument #4</param>
    /// <param name="fe2">Input argument #5</param>
    /// <param name="si">Input argument #6</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object G_CRF_wall_decoding(Object nStates, Object fn1, Object fn2, Object fe1, 
                                Object fe2, Object si)
    {
      return mcr.EvaluateFunction("G_CRF_wall_decoding", nStates, fn1, fn2, fe1, fe2, si);
    }


    /// <summary>
    /// Provides a single output, 7-input Objectinterface to the G_CRF_wall_decoding
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// #function UGM_Decode_ICM UGM_makeEdgeStruct
    /// </remarks>
    /// <param name="nStates">Input argument #1</param>
    /// <param name="fn1">Input argument #2</param>
    /// <param name="fn2">Input argument #3</param>
    /// <param name="fe1">Input argument #4</param>
    /// <param name="fe2">Input argument #5</param>
    /// <param name="si">Input argument #6</param>
    /// <param name="sj">Input argument #7</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object G_CRF_wall_decoding(Object nStates, Object fn1, Object fn2, Object fe1, 
                                Object fe2, Object si, Object sj)
    {
      return mcr.EvaluateFunction("G_CRF_wall_decoding", nStates, fn1, fn2, fe1, fe2, si, sj);
    }


    /// <summary>
    /// Provides a single output, 8-input Objectinterface to the G_CRF_wall_decoding
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// #function UGM_Decode_ICM UGM_makeEdgeStruct
    /// </remarks>
    /// <param name="nStates">Input argument #1</param>
    /// <param name="fn1">Input argument #2</param>
    /// <param name="fn2">Input argument #3</param>
    /// <param name="fe1">Input argument #4</param>
    /// <param name="fe2">Input argument #5</param>
    /// <param name="si">Input argument #6</param>
    /// <param name="sj">Input argument #7</param>
    /// <param name="w">Input argument #8</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object G_CRF_wall_decoding(Object nStates, Object fn1, Object fn2, Object fe1, 
                                Object fe2, Object si, Object sj, Object w)
    {
      return mcr.EvaluateFunction("G_CRF_wall_decoding", nStates, fn1, fn2, fe1, fe2, si, sj, w);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the G_CRF_wall_decoding MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// #function UGM_Decode_ICM UGM_makeEdgeStruct
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] G_CRF_wall_decoding(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "G_CRF_wall_decoding", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the G_CRF_wall_decoding MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// #function UGM_Decode_ICM UGM_makeEdgeStruct
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="nStates">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] G_CRF_wall_decoding(int numArgsOut, Object nStates)
    {
      return mcr.EvaluateFunction(numArgsOut, "G_CRF_wall_decoding", nStates);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the G_CRF_wall_decoding MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// #function UGM_Decode_ICM UGM_makeEdgeStruct
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="nStates">Input argument #1</param>
    /// <param name="fn1">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] G_CRF_wall_decoding(int numArgsOut, Object nStates, Object fn1)
    {
      return mcr.EvaluateFunction(numArgsOut, "G_CRF_wall_decoding", nStates, fn1);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the G_CRF_wall_decoding MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// #function UGM_Decode_ICM UGM_makeEdgeStruct
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="nStates">Input argument #1</param>
    /// <param name="fn1">Input argument #2</param>
    /// <param name="fn2">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] G_CRF_wall_decoding(int numArgsOut, Object nStates, Object fn1, 
                                  Object fn2)
    {
      return mcr.EvaluateFunction(numArgsOut, "G_CRF_wall_decoding", nStates, fn1, fn2);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the G_CRF_wall_decoding MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// #function UGM_Decode_ICM UGM_makeEdgeStruct
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="nStates">Input argument #1</param>
    /// <param name="fn1">Input argument #2</param>
    /// <param name="fn2">Input argument #3</param>
    /// <param name="fe1">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] G_CRF_wall_decoding(int numArgsOut, Object nStates, Object fn1, 
                                  Object fn2, Object fe1)
    {
      return mcr.EvaluateFunction(numArgsOut, "G_CRF_wall_decoding", nStates, fn1, fn2, fe1);
    }


    /// <summary>
    /// Provides the standard 5-input Object interface to the G_CRF_wall_decoding MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// #function UGM_Decode_ICM UGM_makeEdgeStruct
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="nStates">Input argument #1</param>
    /// <param name="fn1">Input argument #2</param>
    /// <param name="fn2">Input argument #3</param>
    /// <param name="fe1">Input argument #4</param>
    /// <param name="fe2">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] G_CRF_wall_decoding(int numArgsOut, Object nStates, Object fn1, 
                                  Object fn2, Object fe1, Object fe2)
    {
      return mcr.EvaluateFunction(numArgsOut, "G_CRF_wall_decoding", nStates, fn1, fn2, fe1, fe2);
    }


    /// <summary>
    /// Provides the standard 6-input Object interface to the G_CRF_wall_decoding MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// #function UGM_Decode_ICM UGM_makeEdgeStruct
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="nStates">Input argument #1</param>
    /// <param name="fn1">Input argument #2</param>
    /// <param name="fn2">Input argument #3</param>
    /// <param name="fe1">Input argument #4</param>
    /// <param name="fe2">Input argument #5</param>
    /// <param name="si">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] G_CRF_wall_decoding(int numArgsOut, Object nStates, Object fn1, 
                                  Object fn2, Object fe1, Object fe2, Object si)
    {
      return mcr.EvaluateFunction(numArgsOut, "G_CRF_wall_decoding", nStates, fn1, fn2, fe1, fe2, si);
    }


    /// <summary>
    /// Provides the standard 7-input Object interface to the G_CRF_wall_decoding MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// #function UGM_Decode_ICM UGM_makeEdgeStruct
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="nStates">Input argument #1</param>
    /// <param name="fn1">Input argument #2</param>
    /// <param name="fn2">Input argument #3</param>
    /// <param name="fe1">Input argument #4</param>
    /// <param name="fe2">Input argument #5</param>
    /// <param name="si">Input argument #6</param>
    /// <param name="sj">Input argument #7</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] G_CRF_wall_decoding(int numArgsOut, Object nStates, Object fn1, 
                                  Object fn2, Object fe1, Object fe2, Object si, Object 
                                  sj)
    {
      return mcr.EvaluateFunction(numArgsOut, "G_CRF_wall_decoding", nStates, fn1, fn2, fe1, fe2, si, sj);
    }


    /// <summary>
    /// Provides the standard 8-input Object interface to the G_CRF_wall_decoding MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// #function UGM_Decode_ICM UGM_makeEdgeStruct
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="nStates">Input argument #1</param>
    /// <param name="fn1">Input argument #2</param>
    /// <param name="fn2">Input argument #3</param>
    /// <param name="fe1">Input argument #4</param>
    /// <param name="fe2">Input argument #5</param>
    /// <param name="si">Input argument #6</param>
    /// <param name="sj">Input argument #7</param>
    /// <param name="w">Input argument #8</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] G_CRF_wall_decoding(int numArgsOut, Object nStates, Object fn1, 
                                  Object fn2, Object fe1, Object fe2, Object si, Object 
                                  sj, Object w)
    {
      return mcr.EvaluateFunction(numArgsOut, "G_CRF_wall_decoding", nStates, fn1, fn2, fe1, fe2, si, sj, w);
    }


    /// <summary>
    /// Provides an interface for the G_CRF_wall_decoding function in which the input and
    /// output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// #function UGM_Decode_ICM UGM_makeEdgeStruct
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("G_CRF_wall_decoding", 8, 1, 0)]
    protected void G_CRF_wall_decoding(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("G_CRF_wall_decoding", numArgsOut, ref argsOut, argsIn, varArgsIn);
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
