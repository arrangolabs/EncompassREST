using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class UnderwritingConditionLog : IDirty
    {
        private Value<string> _addedBy;
        public string AddedBy { get { return _addedBy; } set { _addedBy = value; } }
        private DirtyList<LogAlert> _alerts;
        public IList<LogAlert> Alerts { get { var v = _alerts; return v ?? Interlocked.CompareExchange(ref _alerts, (v = new DirtyList<LogAlert>()), null) ?? v; } set { _alerts = new DirtyList<LogAlert>(value); } }
        private Value<string> _alertsXml;
        public string AlertsXml { get { return _alertsXml; } set { _alertsXml = value; } }
        private Value<bool?> _allowToClearIndicator;
        public bool? AllowToClearIndicator { get { return _allowToClearIndicator; } set { _allowToClearIndicator = value; } }
        private Value<string> _category;
        public string Category { get { return _category; } set { _category = value; } }
        private Value<bool?> _cleared;
        public bool? Cleared { get { return _cleared; } set { _cleared = value; } }
        private Value<string> _clearedBy;
        public string ClearedBy { get { return _clearedBy; } set { _clearedBy = value; } }
        private DirtyList<LogComment> _commentList;
        public IList<LogComment> CommentList { get { var v = _commentList; return v ?? Interlocked.CompareExchange(ref _commentList, (v = new DirtyList<LogComment>()), null) ?? v; } set { _commentList = new DirtyList<LogComment>(value); } }
        private Value<string> _commentListXml;
        public string CommentListXml { get { return _commentListXml; } set { _commentListXml = value; } }
        private Value<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private Value<DateTime?> _dateAddedUtc;
        public DateTime? DateAddedUtc { get { return _dateAddedUtc; } set { _dateAddedUtc = value; } }
        private Value<DateTime?> _dateClearedUtc;
        public DateTime? DateClearedUtc { get { return _dateClearedUtc; } set { _dateClearedUtc = value; } }
        private Value<DateTime?> _dateExpected;
        public DateTime? DateExpected { get { return _dateExpected; } set { _dateExpected = value; } }
        private Value<DateTime?> _dateExpiredUtc;
        public DateTime? DateExpiredUtc { get { return _dateExpiredUtc; } set { _dateExpiredUtc = value; } }
        private Value<DateTime?> _dateFulfilledUtc;
        public DateTime? DateFulfilledUtc { get { return _dateFulfilledUtc; } set { _dateFulfilledUtc = value; } }
        private Value<DateTime?> _dateReceived;
        public DateTime? DateReceived { get { return _dateReceived; } set { _dateReceived = value; } }
        private Value<DateTime?> _dateReceivedUtc;
        public DateTime? DateReceivedUtc { get { return _dateReceivedUtc; } set { _dateReceivedUtc = value; } }
        private Value<DateTime?> _dateRejectedUtc;
        public DateTime? DateRejectedUtc { get { return _dateRejectedUtc; } set { _dateRejectedUtc = value; } }
        private Value<DateTime?> _dateRequestedUtc;
        public DateTime? DateRequestedUtc { get { return _dateRequestedUtc; } set { _dateRequestedUtc = value; } }
        private Value<DateTime?> _dateRerequestedUtc;
        public DateTime? DateRerequestedUtc { get { return _dateRerequestedUtc; } set { _dateRerequestedUtc = value; } }
        private Value<DateTime?> _dateReviewedUtc;
        public DateTime? DateReviewedUtc { get { return _dateReviewedUtc; } set { _dateReviewedUtc = value; } }
        private Value<DateTime?> _dateUtc;
        public DateTime? DateUtc { get { return _dateUtc; } set { _dateUtc = value; } }
        private Value<DateTime?> _dateWaivedUtc;
        public DateTime? DateWaivedUtc { get { return _dateWaivedUtc; } set { _dateWaivedUtc = value; } }
        private Value<string> _description;
        public string Description { get { return _description; } set { _description = value; } }
        private Value<string> _details;
        public string Details { get { return _details; } set { _details = value; } }
        private Value<bool?> _expected;
        public bool? Expected { get { return _expected; } set { _expected = value; } }
        private Value<bool?> _fileAttachmentsMigrated;
        public bool? FileAttachmentsMigrated { get { return _fileAttachmentsMigrated; } set { _fileAttachmentsMigrated = value; } }
        private Value<int?> _forRoleId;
        public int? ForRoleId { get { return _forRoleId; } set { _forRoleId = value; } }
        private Value<bool?> _fulfilled;
        public bool? Fulfilled { get { return _fulfilled; } set { _fulfilled = value; } }
        private Value<string> _fulfilledBy;
        public string FulfilledBy { get { return _fulfilledBy; } set { _fulfilledBy = value; } }
        private Value<string> _guid;
        public string Guid { get { return _guid; } set { _guid = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<bool?> _isExternalIndicator;
        public bool? IsExternalIndicator { get { return _isExternalIndicator; } set { _isExternalIndicator = value; } }
        private Value<bool?> _isInternalIndicator;
        public bool? IsInternalIndicator { get { return _isInternalIndicator; } set { _isInternalIndicator = value; } }
        private Value<bool?> _isPastDue;
        public bool? IsPastDue { get { return _isPastDue; } set { _isPastDue = value; } }
        private Value<bool?> _isSystemSpecificIndicator;
        public bool? IsSystemSpecificIndicator { get { return _isSystemSpecificIndicator; } set { _isSystemSpecificIndicator = value; } }
        private Value<int?> _logRecordIndex;
        public int? LogRecordIndex { get { return _logRecordIndex; } set { _logRecordIndex = value; } }
        private Value<string> _pairId;
        public string PairId { get { return _pairId; } set { _pairId = value; } }
        private Value<string> _priorTo;
        public string PriorTo { get { return _priorTo; } set { _priorTo = value; } }
        private Value<bool?> _received;
        public bool? Received { get { return _received; } set { _received = value; } }
        private Value<string> _receivedBy;
        public string ReceivedBy { get { return _receivedBy; } set { _receivedBy = value; } }
        private Value<bool?> _rejected;
        public bool? Rejected { get { return _rejected; } set { _rejected = value; } }
        private Value<string> _rejectedBy;
        public string RejectedBy { get { return _rejectedBy; } set { _rejectedBy = value; } }
        private Value<bool?> _requested;
        public bool? Requested { get { return _requested; } set { _requested = value; } }
        private Value<string> _requestedBy;
        public string RequestedBy { get { return _requestedBy; } set { _requestedBy = value; } }
        private Value<bool?> _rerequested;
        public bool? Rerequested { get { return _rerequested; } set { _rerequested = value; } }
        private Value<string> _rerequestedBy;
        public string RerequestedBy { get { return _rerequestedBy; } set { _rerequestedBy = value; } }
        private Value<bool?> _reviewed;
        public bool? Reviewed { get { return _reviewed; } set { _reviewed = value; } }
        private Value<string> _reviewedBy;
        public string ReviewedBy { get { return _reviewedBy; } set { _reviewedBy = value; } }
        private Value<string> _source;
        public string Source { get { return _source; } set { _source = value; } }
        private Value<string> _status;
        public string Status { get { return _status; } set { _status = value; } }
        private Value<string> _statusDescription;
        public string StatusDescription { get { return _statusDescription; } set { _statusDescription = value; } }
        private Value<string> _systemId;
        public string SystemId { get { return _systemId; } set { _systemId = value; } }
        private Value<string> _title;
        public string Title { get { return _title; } set { _title = value; } }
        private Value<bool?> _waived;
        public bool? Waived { get { return _waived; } set { _waived = value; } }
        private Value<string> _waivedBy;
        public string WaivedBy { get { return _waivedBy; } set { _waivedBy = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _addedBy.Dirty
                    || _alertsXml.Dirty
                    || _allowToClearIndicator.Dirty
                    || _category.Dirty
                    || _cleared.Dirty
                    || _clearedBy.Dirty
                    || _commentListXml.Dirty
                    || _comments.Dirty
                    || _dateAddedUtc.Dirty
                    || _dateClearedUtc.Dirty
                    || _dateExpected.Dirty
                    || _dateExpiredUtc.Dirty
                    || _dateFulfilledUtc.Dirty
                    || _dateReceived.Dirty
                    || _dateReceivedUtc.Dirty
                    || _dateRejectedUtc.Dirty
                    || _dateRequestedUtc.Dirty
                    || _dateRerequestedUtc.Dirty
                    || _dateReviewedUtc.Dirty
                    || _dateUtc.Dirty
                    || _dateWaivedUtc.Dirty
                    || _description.Dirty
                    || _details.Dirty
                    || _expected.Dirty
                    || _fileAttachmentsMigrated.Dirty
                    || _forRoleId.Dirty
                    || _fulfilled.Dirty
                    || _fulfilledBy.Dirty
                    || _guid.Dirty
                    || _id.Dirty
                    || _isExternalIndicator.Dirty
                    || _isInternalIndicator.Dirty
                    || _isPastDue.Dirty
                    || _isSystemSpecificIndicator.Dirty
                    || _logRecordIndex.Dirty
                    || _pairId.Dirty
                    || _priorTo.Dirty
                    || _received.Dirty
                    || _receivedBy.Dirty
                    || _rejected.Dirty
                    || _rejectedBy.Dirty
                    || _requested.Dirty
                    || _requestedBy.Dirty
                    || _rerequested.Dirty
                    || _rerequestedBy.Dirty
                    || _reviewed.Dirty
                    || _reviewedBy.Dirty
                    || _source.Dirty
                    || _status.Dirty
                    || _statusDescription.Dirty
                    || _systemId.Dirty
                    || _title.Dirty
                    || _waived.Dirty
                    || _waivedBy.Dirty
                    || _alerts?.Dirty == true
                    || _commentList?.Dirty == true;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _addedBy.Dirty = value;
                _alertsXml.Dirty = value;
                _allowToClearIndicator.Dirty = value;
                _category.Dirty = value;
                _cleared.Dirty = value;
                _clearedBy.Dirty = value;
                _commentListXml.Dirty = value;
                _comments.Dirty = value;
                _dateAddedUtc.Dirty = value;
                _dateClearedUtc.Dirty = value;
                _dateExpected.Dirty = value;
                _dateExpiredUtc.Dirty = value;
                _dateFulfilledUtc.Dirty = value;
                _dateReceived.Dirty = value;
                _dateReceivedUtc.Dirty = value;
                _dateRejectedUtc.Dirty = value;
                _dateRequestedUtc.Dirty = value;
                _dateRerequestedUtc.Dirty = value;
                _dateReviewedUtc.Dirty = value;
                _dateUtc.Dirty = value;
                _dateWaivedUtc.Dirty = value;
                _description.Dirty = value;
                _details.Dirty = value;
                _expected.Dirty = value;
                _fileAttachmentsMigrated.Dirty = value;
                _forRoleId.Dirty = value;
                _fulfilled.Dirty = value;
                _fulfilledBy.Dirty = value;
                _guid.Dirty = value;
                _id.Dirty = value;
                _isExternalIndicator.Dirty = value;
                _isInternalIndicator.Dirty = value;
                _isPastDue.Dirty = value;
                _isSystemSpecificIndicator.Dirty = value;
                _logRecordIndex.Dirty = value;
                _pairId.Dirty = value;
                _priorTo.Dirty = value;
                _received.Dirty = value;
                _receivedBy.Dirty = value;
                _rejected.Dirty = value;
                _rejectedBy.Dirty = value;
                _requested.Dirty = value;
                _requestedBy.Dirty = value;
                _rerequested.Dirty = value;
                _rerequestedBy.Dirty = value;
                _reviewed.Dirty = value;
                _reviewedBy.Dirty = value;
                _source.Dirty = value;
                _status.Dirty = value;
                _statusDescription.Dirty = value;
                _systemId.Dirty = value;
                _title.Dirty = value;
                _waived.Dirty = value;
                _waivedBy.Dirty = value;
                if (_alerts != null) _alerts.Dirty = value;
                if (_commentList != null) _commentList.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}