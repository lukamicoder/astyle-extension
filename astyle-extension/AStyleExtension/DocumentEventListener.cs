using System;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;

namespace AStyleExtension {
    public class DocumentEventListener : IDisposable, IVsRunningDocTableEvents3 {
        private RunningDocumentTable _table;
        private uint _cookie;
        private bool _isDisposed;

        public delegate int OnBeforeSaveHandler(uint docCookie);
        public event OnBeforeSaveHandler BeforeSave;

        public DocumentEventListener(IServiceProvider package) {
            _table = new RunningDocumentTable(package);
            _cookie = _table.Advise(this);
		}

        public string GetDocumentName(uint docCookie) {
            return _table.GetDocumentInfo(docCookie).Moniker;
        }

        public int OnAfterAttributeChange(uint docCookie, uint grfAttribs) {
            return VSConstants.S_OK;
        }

        public int OnAfterAttributeChangeEx(uint docCookie, uint grfAttribs, IVsHierarchy pHierOld, uint itemidOld, string pszMkDocumentOld, IVsHierarchy pHierNew, uint itemidNew, string pszMkDocumentNew) {
            return VSConstants.S_OK;
        }

        public int OnAfterDocumentWindowHide(uint docCookie, IVsWindowFrame pFrame) {
            return VSConstants.S_OK;
        }

        public int OnAfterFirstDocumentLock(uint docCookie, uint dwRDTLockType, uint dwReadLocksRemaining, uint dwEditLocksRemaining) {
            return VSConstants.S_OK;
        }

        public int OnAfterSave(uint docCookie) {
            return VSConstants.S_OK;
        }

        public int OnBeforeDocumentWindowShow(uint docCookie, int fFirstShow, IVsWindowFrame pFrame) {
            return VSConstants.S_OK;
        }

        public int OnBeforeLastDocumentUnlock(uint docCookie, uint dwRDTLockType, uint dwReadLocksRemaining, uint dwEditLocksRemaining) {
            return VSConstants.S_OK;
        }

        public int OnBeforeSave(uint docCookie) {
            if (BeforeSave != null) {
                return BeforeSave(docCookie);
            }
            return VSConstants.S_OK;
        }

        public void Dispose() {
            if (_isDisposed) {
                return;
            }

            _isDisposed = true;

            if (_table != null && _cookie != 0) {
                _table.Unadvise(_cookie);
                _cookie = 0;
            }
        }
    }
}